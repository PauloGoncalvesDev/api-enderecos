﻿using BrazilianAddresses.Communication.Requests;
using BrazilianAddresses.Communication.Responses;

namespace BrazilianAddresses.Application.BusinessRules.IBGEBusinessRule.Interfaces
{
    public interface IGetIBGEAddresses
    {
        public Task<List<AddressResponseJson>> Execute(PaginationBaseRequestJson pagination);

        public Task<List<AddressResponseJson>> Execute(AddressesByStateRequestJson addressesByState);

        public Task<AddressResponseJson> Execute(CityAddressRequestJson cityAddressRequestJson);
    }
}