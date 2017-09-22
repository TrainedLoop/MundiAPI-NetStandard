/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    public class CreatePaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string paymentMethod;
        private Models.CreateCreditCardPaymentRequest creditCard;
        private Models.CreateBoletoPaymentRequest boleto;
        private string currency;
        private Models.CreateVoucherPaymentRequest voucher;
        private List<string> metadata;
        private Models.CreateBankTransferPaymentRequest bankTransfer;
        private string gatewayAffiliationId;
        private int? amount;
        private Models.CreateCheckoutPaymentRequest checkout;

        /// <summary>
        /// Payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod 
        { 
            get 
            {
                return this.paymentMethod; 
            } 
            set 
            {
                this.paymentMethod = value;
                onPropertyChanged("PaymentMethod");
            }
        }

        /// <summary>
        /// Settings for credit card payment
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCreditCardPaymentRequest CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// Settings for boleto payment
        /// </summary>
        [JsonProperty("boleto")]
        public Models.CreateBoletoPaymentRequest Boleto 
        { 
            get 
            {
                return this.boleto; 
            } 
            set 
            {
                this.boleto = value;
                onPropertyChanged("Boleto");
            }
        }

        /// <summary>
        /// Currency. Must be informed using 3 characters
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Settings for voucher payment
        /// </summary>
        [JsonProperty("voucher")]
        public Models.CreateVoucherPaymentRequest Voucher 
        { 
            get 
            {
                return this.voucher; 
            } 
            set 
            {
                this.voucher = value;
                onPropertyChanged("Voucher");
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public List<string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// Settings for bank transfer payment
        /// </summary>
        [JsonProperty("bank_transfer")]
        public Models.CreateBankTransferPaymentRequest BankTransfer 
        { 
            get 
            {
                return this.bankTransfer; 
            } 
            set 
            {
                this.bankTransfer = value;
                onPropertyChanged("BankTransfer");
            }
        }

        /// <summary>
        /// Gateway affiliation code
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId 
        { 
            get 
            {
                return this.gatewayAffiliationId; 
            } 
            set 
            {
                this.gatewayAffiliationId = value;
                onPropertyChanged("GatewayAffiliationId");
            }
        }

        /// <summary>
        /// The amount of the payment, in cents
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Settings for checkout payment
        /// </summary>
        [JsonProperty("checkout")]
        public Models.CreateCheckoutPaymentRequest Checkout 
        { 
            get 
            {
                return this.checkout; 
            } 
            set 
            {
                this.checkout = value;
                onPropertyChanged("Checkout");
            }
        }
    }
} 