CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS dragons(
        id SMALLINT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'This is a dragons Id',
        -- id should be on every table, first thing you put on. Primary key means that it's the unique identifier
        -- smallInt specifies a certain length the id will be, normally use int but this is a small test so I set SMALLINT
        -- not null: required: true
        -- Comment: this just adds stuff to our table to tell people what things are if clarification required. Not needed for this at all
        -- Auto-increment: it'll set it for me
        name CHAR(255) NOT NULL -- CHAR is string notation to mean that the string can be between 0 to 255 characters. Not null means it can't be 0, however
    ) DEFAULT charset utf8 COMMENT '';

-- To add things to a TABLE

INSERT INTO dragons (name) VALUES ('Long')