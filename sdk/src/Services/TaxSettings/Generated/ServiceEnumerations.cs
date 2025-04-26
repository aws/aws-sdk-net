/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TaxSettings
{

    /// <summary>
    /// Constants used for properties of type AddressRoleType.
    /// </summary>
    public class AddressRoleType : ConstantClass
    {

        /// <summary>
        /// Constant BillingAddress for AddressRoleType
        /// </summary>
        public static readonly AddressRoleType BillingAddress = new AddressRoleType("BillingAddress");
        /// <summary>
        /// Constant ContactAddress for AddressRoleType
        /// </summary>
        public static readonly AddressRoleType ContactAddress = new AddressRoleType("ContactAddress");
        /// <summary>
        /// Constant TaxAddress for AddressRoleType
        /// </summary>
        public static readonly AddressRoleType TaxAddress = new AddressRoleType("TaxAddress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddressRoleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddressRoleType FindValue(string value)
        {
            return FindValue<AddressRoleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddressRoleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityExemptionAccountStatus.
    /// </summary>
    public class EntityExemptionAccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant Expired for EntityExemptionAccountStatus
        /// </summary>
        public static readonly EntityExemptionAccountStatus Expired = new EntityExemptionAccountStatus("Expired");
        /// <summary>
        /// Constant None for EntityExemptionAccountStatus
        /// </summary>
        public static readonly EntityExemptionAccountStatus None = new EntityExemptionAccountStatus("None");
        /// <summary>
        /// Constant Pending for EntityExemptionAccountStatus
        /// </summary>
        public static readonly EntityExemptionAccountStatus Pending = new EntityExemptionAccountStatus("Pending");
        /// <summary>
        /// Constant Valid for EntityExemptionAccountStatus
        /// </summary>
        public static readonly EntityExemptionAccountStatus Valid = new EntityExemptionAccountStatus("Valid");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityExemptionAccountStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityExemptionAccountStatus FindValue(string value)
        {
            return FindValue<EntityExemptionAccountStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityExemptionAccountStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HeritageStatus.
    /// </summary>
    public class HeritageStatus : ConstantClass
    {

        /// <summary>
        /// Constant OptIn for HeritageStatus
        /// </summary>
        public static readonly HeritageStatus OptIn = new HeritageStatus("OptIn");
        /// <summary>
        /// Constant OptOut for HeritageStatus
        /// </summary>
        public static readonly HeritageStatus OptOut = new HeritageStatus("OptOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HeritageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HeritageStatus FindValue(string value)
        {
            return FindValue<HeritageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HeritageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndonesiaTaxRegistrationNumberType.
    /// </summary>
    public class IndonesiaTaxRegistrationNumberType : ConstantClass
    {

        /// <summary>
        /// Constant NIK for IndonesiaTaxRegistrationNumberType
        /// </summary>
        public static readonly IndonesiaTaxRegistrationNumberType NIK = new IndonesiaTaxRegistrationNumberType("NIK");
        /// <summary>
        /// Constant NITKU for IndonesiaTaxRegistrationNumberType
        /// </summary>
        public static readonly IndonesiaTaxRegistrationNumberType NITKU = new IndonesiaTaxRegistrationNumberType("NITKU");
        /// <summary>
        /// Constant NPWP for IndonesiaTaxRegistrationNumberType
        /// </summary>
        public static readonly IndonesiaTaxRegistrationNumberType NPWP = new IndonesiaTaxRegistrationNumberType("NPWP");
        /// <summary>
        /// Constant PassportNumber for IndonesiaTaxRegistrationNumberType
        /// </summary>
        public static readonly IndonesiaTaxRegistrationNumberType PassportNumber = new IndonesiaTaxRegistrationNumberType("PassportNumber");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndonesiaTaxRegistrationNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndonesiaTaxRegistrationNumberType FindValue(string value)
        {
            return FindValue<IndonesiaTaxRegistrationNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndonesiaTaxRegistrationNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Industries.
    /// </summary>
    public class Industries : ConstantClass
    {

        /// <summary>
        /// Constant Banks for Industries
        /// </summary>
        public static readonly Industries Banks = new Industries("Banks");
        /// <summary>
        /// Constant CirculatingOrg for Industries
        /// </summary>
        public static readonly Industries CirculatingOrg = new Industries("CirculatingOrg");
        /// <summary>
        /// Constant DevelopmentAgencies for Industries
        /// </summary>
        public static readonly Industries DevelopmentAgencies = new Industries("DevelopmentAgencies");
        /// <summary>
        /// Constant Insurance for Industries
        /// </summary>
        public static readonly Industries Insurance = new Industries("Insurance");
        /// <summary>
        /// Constant PensionAndBenefitFunds for Industries
        /// </summary>
        public static readonly Industries PensionAndBenefitFunds = new Industries("PensionAndBenefitFunds");
        /// <summary>
        /// Constant ProfessionalOrg for Industries
        /// </summary>
        public static readonly Industries ProfessionalOrg = new Industries("ProfessionalOrg");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Industries(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Industries FindValue(string value)
        {
            return FindValue<Industries>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Industries(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsraelCustomerType.
    /// </summary>
    public class IsraelCustomerType : ConstantClass
    {

        /// <summary>
        /// Constant Business for IsraelCustomerType
        /// </summary>
        public static readonly IsraelCustomerType Business = new IsraelCustomerType("Business");
        /// <summary>
        /// Constant Individual for IsraelCustomerType
        /// </summary>
        public static readonly IsraelCustomerType Individual = new IsraelCustomerType("Individual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsraelCustomerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsraelCustomerType FindValue(string value)
        {
            return FindValue<IsraelCustomerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsraelCustomerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsraelDealerType.
    /// </summary>
    public class IsraelDealerType : ConstantClass
    {

        /// <summary>
        /// Constant Authorized for IsraelDealerType
        /// </summary>
        public static readonly IsraelDealerType Authorized = new IsraelDealerType("Authorized");
        /// <summary>
        /// Constant NonAuthorized for IsraelDealerType
        /// </summary>
        public static readonly IsraelDealerType NonAuthorized = new IsraelDealerType("Non-authorized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsraelDealerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsraelDealerType FindValue(string value)
        {
            return FindValue<IsraelDealerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsraelDealerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalaysiaServiceTaxCode.
    /// </summary>
    public class MalaysiaServiceTaxCode : ConstantClass
    {

        /// <summary>
        /// Constant Consultancy for MalaysiaServiceTaxCode
        /// </summary>
        public static readonly MalaysiaServiceTaxCode Consultancy = new MalaysiaServiceTaxCode("Consultancy");
        /// <summary>
        /// Constant DigitalServiceAndElectronicMedium for MalaysiaServiceTaxCode
        /// </summary>
        public static readonly MalaysiaServiceTaxCode DigitalServiceAndElectronicMedium = new MalaysiaServiceTaxCode("Digital Service And Electronic Medium");
        /// <summary>
        /// Constant ITServices for MalaysiaServiceTaxCode
        /// </summary>
        public static readonly MalaysiaServiceTaxCode ITServices = new MalaysiaServiceTaxCode("IT Services");
        /// <summary>
        /// Constant TrainingOrCoaching for MalaysiaServiceTaxCode
        /// </summary>
        public static readonly MalaysiaServiceTaxCode TrainingOrCoaching = new MalaysiaServiceTaxCode("Training Or Coaching");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalaysiaServiceTaxCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalaysiaServiceTaxCode FindValue(string value)
        {
            return FindValue<MalaysiaServiceTaxCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalaysiaServiceTaxCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PersonType.
    /// </summary>
    public class PersonType : ConstantClass
    {

        /// <summary>
        /// Constant Business for PersonType
        /// </summary>
        public static readonly PersonType Business = new PersonType("Business");
        /// <summary>
        /// Constant LegalPerson for PersonType
        /// </summary>
        public static readonly PersonType LegalPerson = new PersonType("Legal Person");
        /// <summary>
        /// Constant PhysicalPerson for PersonType
        /// </summary>
        public static readonly PersonType PhysicalPerson = new PersonType("Physical Person");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PersonType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PersonType FindValue(string value)
        {
            return FindValue<PersonType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PersonType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationType.
    /// </summary>
    public class RegistrationType : ConstantClass
    {

        /// <summary>
        /// Constant IntraEU for RegistrationType
        /// </summary>
        public static readonly RegistrationType IntraEU = new RegistrationType("Intra-EU");
        /// <summary>
        /// Constant Local for RegistrationType
        /// </summary>
        public static readonly RegistrationType Local = new RegistrationType("Local");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationType FindValue(string value)
        {
            return FindValue<RegistrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SaudiArabiaTaxRegistrationNumberType.
    /// </summary>
    public class SaudiArabiaTaxRegistrationNumberType : ConstantClass
    {

        /// <summary>
        /// Constant CommercialRegistrationNumber for SaudiArabiaTaxRegistrationNumberType
        /// </summary>
        public static readonly SaudiArabiaTaxRegistrationNumberType CommercialRegistrationNumber = new SaudiArabiaTaxRegistrationNumberType("CommercialRegistrationNumber");
        /// <summary>
        /// Constant TaxIdentificationNumber for SaudiArabiaTaxRegistrationNumberType
        /// </summary>
        public static readonly SaudiArabiaTaxRegistrationNumberType TaxIdentificationNumber = new SaudiArabiaTaxRegistrationNumberType("TaxIdentificationNumber");
        /// <summary>
        /// Constant TaxRegistrationNumber for SaudiArabiaTaxRegistrationNumberType
        /// </summary>
        public static readonly SaudiArabiaTaxRegistrationNumberType TaxRegistrationNumber = new SaudiArabiaTaxRegistrationNumberType("TaxRegistrationNumber");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SaudiArabiaTaxRegistrationNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SaudiArabiaTaxRegistrationNumberType FindValue(string value)
        {
            return FindValue<SaudiArabiaTaxRegistrationNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SaudiArabiaTaxRegistrationNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Sector.
    /// </summary>
    public class Sector : ConstantClass
    {

        /// <summary>
        /// Constant Business for Sector
        /// </summary>
        public static readonly Sector Business = new Sector("Business");
        /// <summary>
        /// Constant Government for Sector
        /// </summary>
        public static readonly Sector Government = new Sector("Government");
        /// <summary>
        /// Constant Individual for Sector
        /// </summary>
        public static readonly Sector Individual = new Sector("Individual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Sector(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Sector FindValue(string value)
        {
            return FindValue<Sector>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Sector(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupplementalTaxRegistrationType.
    /// </summary>
    public class SupplementalTaxRegistrationType : ConstantClass
    {

        /// <summary>
        /// Constant VAT for SupplementalTaxRegistrationType
        /// </summary>
        public static readonly SupplementalTaxRegistrationType VAT = new SupplementalTaxRegistrationType("VAT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupplementalTaxRegistrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupplementalTaxRegistrationType FindValue(string value)
        {
            return FindValue<SupplementalTaxRegistrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupplementalTaxRegistrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaxRegistrationNumberType.
    /// </summary>
    public class TaxRegistrationNumberType : ConstantClass
    {

        /// <summary>
        /// Constant LocalRegistrationNumber for TaxRegistrationNumberType
        /// </summary>
        public static readonly TaxRegistrationNumberType LocalRegistrationNumber = new TaxRegistrationNumberType("LocalRegistrationNumber");
        /// <summary>
        /// Constant TaxRegistrationNumber for TaxRegistrationNumberType
        /// </summary>
        public static readonly TaxRegistrationNumberType TaxRegistrationNumber = new TaxRegistrationNumberType("TaxRegistrationNumber");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaxRegistrationNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaxRegistrationNumberType FindValue(string value)
        {
            return FindValue<TaxRegistrationNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaxRegistrationNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaxRegistrationStatus.
    /// </summary>
    public class TaxRegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleted for TaxRegistrationStatus
        /// </summary>
        public static readonly TaxRegistrationStatus Deleted = new TaxRegistrationStatus("Deleted");
        /// <summary>
        /// Constant Pending for TaxRegistrationStatus
        /// </summary>
        public static readonly TaxRegistrationStatus Pending = new TaxRegistrationStatus("Pending");
        /// <summary>
        /// Constant Rejected for TaxRegistrationStatus
        /// </summary>
        public static readonly TaxRegistrationStatus Rejected = new TaxRegistrationStatus("Rejected");
        /// <summary>
        /// Constant Verified for TaxRegistrationStatus
        /// </summary>
        public static readonly TaxRegistrationStatus Verified = new TaxRegistrationStatus("Verified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaxRegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaxRegistrationStatus FindValue(string value)
        {
            return FindValue<TaxRegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaxRegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaxRegistrationType.
    /// </summary>
    public class TaxRegistrationType : ConstantClass
    {

        /// <summary>
        /// Constant CNPJ for TaxRegistrationType
        /// </summary>
        public static readonly TaxRegistrationType CNPJ = new TaxRegistrationType("CNPJ");
        /// <summary>
        /// Constant CPF for TaxRegistrationType
        /// </summary>
        public static readonly TaxRegistrationType CPF = new TaxRegistrationType("CPF");
        /// <summary>
        /// Constant GST for TaxRegistrationType
        /// </summary>
        public static readonly TaxRegistrationType GST = new TaxRegistrationType("GST");
        /// <summary>
        /// Constant NRIC for TaxRegistrationType
        /// </summary>
        public static readonly TaxRegistrationType NRIC = new TaxRegistrationType("NRIC");
        /// <summary>
        /// Constant SST for TaxRegistrationType
        /// </summary>
        public static readonly TaxRegistrationType SST = new TaxRegistrationType("SST");
        /// <summary>
        /// Constant TIN for TaxRegistrationType
        /// </summary>
        public static readonly TaxRegistrationType TIN = new TaxRegistrationType("TIN");
        /// <summary>
        /// Constant VAT for TaxRegistrationType
        /// </summary>
        public static readonly TaxRegistrationType VAT = new TaxRegistrationType("VAT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaxRegistrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaxRegistrationType FindValue(string value)
        {
            return FindValue<TaxRegistrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaxRegistrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UkraineTrnType.
    /// </summary>
    public class UkraineTrnType : ConstantClass
    {

        /// <summary>
        /// Constant Business for UkraineTrnType
        /// </summary>
        public static readonly UkraineTrnType Business = new UkraineTrnType("Business");
        /// <summary>
        /// Constant Individual for UkraineTrnType
        /// </summary>
        public static readonly UkraineTrnType Individual = new UkraineTrnType("Individual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UkraineTrnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UkraineTrnType FindValue(string value)
        {
            return FindValue<UkraineTrnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UkraineTrnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UzbekistanTaxRegistrationNumberType.
    /// </summary>
    public class UzbekistanTaxRegistrationNumberType : ConstantClass
    {

        /// <summary>
        /// Constant Business for UzbekistanTaxRegistrationNumberType
        /// </summary>
        public static readonly UzbekistanTaxRegistrationNumberType Business = new UzbekistanTaxRegistrationNumberType("Business");
        /// <summary>
        /// Constant Individual for UzbekistanTaxRegistrationNumberType
        /// </summary>
        public static readonly UzbekistanTaxRegistrationNumberType Individual = new UzbekistanTaxRegistrationNumberType("Individual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UzbekistanTaxRegistrationNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UzbekistanTaxRegistrationNumberType FindValue(string value)
        {
            return FindValue<UzbekistanTaxRegistrationNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UzbekistanTaxRegistrationNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionErrorCode.
    /// </summary>
    public class ValidationExceptionErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ExpiredToken for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode ExpiredToken = new ValidationExceptionErrorCode("ExpiredToken");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode FieldValidationFailed = new ValidationExceptionErrorCode("FieldValidationFailed");
        /// <summary>
        /// Constant InvalidToken for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode InvalidToken = new ValidationExceptionErrorCode("InvalidToken");
        /// <summary>
        /// Constant MalformedToken for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode MalformedToken = new ValidationExceptionErrorCode("MalformedToken");
        /// <summary>
        /// Constant MissingInput for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode MissingInput = new ValidationExceptionErrorCode("MissingInput");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionErrorCode FindValue(string value)
        {
            return FindValue<ValidationExceptionErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionErrorCode(string value)
        {
            return FindValue(value);
        }
    }

}