﻿using FreeCourse.Services.Order.Domain.Core;

namespace FreeCourse.Services.Order.Domain.OrderAggregate;

public class Address : ValueObject //EF Core Feature -> Owned Type (Database'de bir qarshiligi olmayan model)
{
    public string Province { get; private set; }
    public string District { get; private set; }
    public string Street { get; private set; }
    public string ZipCode { get; private set; }
    public string Line { get; private set; }

    public Address(string province, string district, string street, string zipCode, string line)
    {
        Province = province;
        District = district;
        Street = street;
        ZipCode = zipCode;
        Line = line;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Province;
        yield return District;
        yield return Street;
        yield return ZipCode;
        yield return Line;
    }
}
