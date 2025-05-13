-- Create the Tasks table
CREATE TABLE Tasks (
    TaskID INTEGER PRIMARY KEY AUTOINCREMENT,
    Description TEXT NOT NULL,
    IsCompleted BOOLEAN DEFAULT FALSE,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Optional: Insert some sample tasks
INSERT INTO Tasks (Description) VALUES ('Learn C# basics');
INSERT INTO Tasks (Description) VALUES ('Build a to-do list app');
INSERT INTO Tasks (Description) VALUES ('Push project to GitHub');
