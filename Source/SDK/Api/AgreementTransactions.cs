//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PayPal.Api
{
    public class AgreementTransactions : PayPalSerializableObject
    {
        /// <summary>
        /// Array of agreement_transaction object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agreement_transaction_list")]
        public List<AgreementTransaction> agreement_transaction_list { get; set; }
    }
}