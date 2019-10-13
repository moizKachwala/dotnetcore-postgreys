
\connect blogdb

CREATE TABLE test
(
    id serial PRIMARY KEY,
    handle  VARCHAR (50)  NOT NULL
);

ALTER TABLE "test" OWNER TO bloguser;