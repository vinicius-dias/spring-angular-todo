CREATE TABLE IF NOT EXISTS POC_USER (
  ID INT NOT NULL,
  NAME VARCHAR(80) NOT NULL,
  PRIMARY KEY (ID));

CREATE TABLE IF NOT EXISTS POC_TASK (
  ID INT NOT NULL,
  USER_ID INT NOT NULL,
  DESCRIPTION VARCHAR(200) NOT NULL,
  DUE_DATE TIMESTAMP NULL,
  DONE BOOLEAN NOT NULL DEFAULT FALSE,
  PRIMARY KEY (ID),
  CONSTRAINT fk_POC_USER_TASK
    FOREIGN KEY (USER_ID)
    REFERENCES POC_USER (ID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

CREATE SEQUENCE POC_TASK_SEQ INCREMENT 1;

GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA public TO ubc_poc_role;
GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA public TO ubc_poc_role;