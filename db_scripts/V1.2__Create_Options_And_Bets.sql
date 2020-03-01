CREATE TABLE IF NOT EXISTS options (
    id SERIAL PRIMARY KEY,
    option_name VARCHAR(100) NOT NULL,
    event_id INT NOT NULL REFERENCES events
);

CREATE TABLE IF NOT EXISTS bets (
    id SERIAL PRIMARY KEY,
    amount DECIMAL NOT NULL,
    currency_code VARCHAR(12) NOT NULL,
    event_id INT NOT NULL REFERENCES events
);