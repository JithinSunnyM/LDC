CREATE PROC GetTotalFootfallCountPerPremises
AS
BEGIN
SELECT 
	b.Business,
	p.StreetNo,
	p.Street,
	p.PostCode,
	SUM(f.Count) AS FootfallCount /* For the 'FootfallCount' field you requested, I processed the 
	sum of all the count fields in the 'Footfall' table for a particular 'PremisesId' */
FROM 
	Businesses b
	INNER JOIN Premises p ON
	p.BusinessId = b.Id
	INNER JOIN Footfall f ON
	f.PremisesId = p.Id
GROUP BY
	b.Business,
	p.Street,
	p.PostCode,
	p.StreetNo
END