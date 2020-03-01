
# docker run -p 5433:5432 postgres
# psql -U postgres --password -h localhost -p 5433 postgres -f ./local_db_create.sql

CREATE USER lifebet_sa WITH PASSWORD 'pwd1';

CREATE DATABASE lifebet
   WITH OWNER lifebet_sa 
   TEMPLATE template0
   ENCODING 'SQL_ASCII'
   TABLESPACE  pg_default
   LC_COLLATE  'C'
   LC_CTYPE  'C'
   CONNECTION LIMIT  -1;