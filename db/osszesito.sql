-- Tagonként hány edzésen vett részt az elmúlt 30 napban
SELECT t.nev, COUNT(*) AS alkalom
FROM jelenletek j JOIN tagok t ON t.id = j.tag_id JOIN edzesek e ON e.id = j.edzes_id
WHERE e.datum >= date('now', '-30 day')
GROUP BY t.nev ORDER BY alkalom DESC;
