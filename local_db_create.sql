-- docker create volume lifebet
-- docker run -d -p 5433:5432 -v lifebet:/var/lib/postgresql/data postgres
-- psql -U postgres --password -h localhost -p 5433 -f ./local_db_create.sql

CREATE USER lifebet_sa WITH PASSWORD 'pwd1';

CREATE DATABASE lifebet
   WITH OWNER lifebet_sa 
   TEMPLATE template0
   ENCODING 'SQL_ASCII'
   TABLESPACE  pg_default
   LC_COLLATE  'C'
   LC_CTYPE  'C'
   CONNECTION LIMIT  -1;