CREATE TABLE tagok (
  id INTEGER PRIMARY KEY,
  nev TEXT NOT NULL,
  szuletesi_ev INTEGER NOT NULL,
  szakosztaly TEXT NOT NULL
);

CREATE TABLE edzesek (
  id INTEGER PRIMARY KEY,
  datum TEXT NOT NULL,
  szakosztaly TEXT NOT NULL,
  edzo TEXT NOT NULL,
  idotartam_perc INTEGER NOT NULL CHECK (idotartam_perc > 0)
);

CREATE TABLE jelenletek (
  edzes_id INTEGER NOT NULL REFERENCES edzesek (id),
  tag_id INTEGER NOT NULL REFERENCES tagok (id),
  PRIMARY KEY (edzes_id, tag_id)
);
