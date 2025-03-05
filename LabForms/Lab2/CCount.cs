namespace LabForms.Lab2;

public class CCount
{
    public int Id { get; set; }

    public int CountNumber { get; set; }
    public int Value { get; set; }
    public int Cost { get; set; }
    public DateTime Date
    {
        get
        {
            var dateTime = new DateTime(date);
            return dateTime.Date;
        }
        set { date = value.Ticks; }
    }

    private long date;

    public CCount() { }

    public CCount(CCount ccount)
    {
        Id = ccount.Id;
        CountNumber = ccount.CountNumber;
        Value = ccount.Value;
        Cost = ccount.Cost;
        Date = ccount.Date;
    }

    public CCount(int id, int countNumber, int value, int cost, DateTime date)
    {
        Id = id;
        CountNumber = countNumber;
        Value = value;
        Cost = cost;
        Date = date;
    }

    public override string ToString()
    {
        return $"Id: {Id}, CountNumber: {CountNumber}, Value: {Value}, Cost: {Cost}, Date: {Date}";
    }
}
