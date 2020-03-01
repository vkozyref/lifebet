create user lifebet_sa with password 'pwd1';

CREATE DATABASE lifebet
   WITH OWNER lifebet_sa 
   TEMPLATE template0
   ENCODING 'SQL_ASCII'
   TABLESPACE  pg_default
   LC_COLLATE  'C'
   LC_CTYPE  'C'
   CONNECTION LIMIT  -1;