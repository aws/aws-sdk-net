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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Outposts
{

    /// <summary>
    /// Constants used for properties of type AddressType.
    /// </summary>
    public class AddressType : ConstantClass
    {

        /// <summary>
        /// Constant OPERATING_ADDRESS for AddressType
        /// </summary>
        public static readonly AddressType OPERATING_ADDRESS = new AddressType("OPERATING_ADDRESS");
        /// <summary>
        /// Constant SHIPPING_ADDRESS for AddressType
        /// </summary>
        public static readonly AddressType SHIPPING_ADDRESS = new AddressType("SHIPPING_ADDRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddressType FindValue(string value)
        {
            return FindValue<AddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetState.
    /// </summary>
    public class AssetState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AssetState
        /// </summary>
        public static readonly AssetState ACTIVE = new AssetState("ACTIVE");
        /// <summary>
        /// Constant RETIRING for AssetState
        /// </summary>
        public static readonly AssetState RETIRING = new AssetState("RETIRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetState FindValue(string value)
        {
            return FindValue<AssetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetType.
    /// </summary>
    public class AssetType : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTE for AssetType
        /// </summary>
        public static readonly AssetType COMPUTE = new AssetType("COMPUTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetType FindValue(string value)
        {
            return FindValue<AssetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CatalogItemClass.
    /// </summary>
    public class CatalogItemClass : ConstantClass
    {

        /// <summary>
        /// Constant RACK for CatalogItemClass
        /// </summary>
        public static readonly CatalogItemClass RACK = new CatalogItemClass("RACK");
        /// <summary>
        /// Constant SERVER for CatalogItemClass
        /// </summary>
        public static readonly CatalogItemClass SERVER = new CatalogItemClass("SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CatalogItemClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CatalogItemClass FindValue(string value)
        {
            return FindValue<CatalogItemClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CatalogItemClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CatalogItemStatus.
    /// </summary>
    public class CatalogItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for CatalogItemStatus
        /// </summary>
        public static readonly CatalogItemStatus AVAILABLE = new CatalogItemStatus("AVAILABLE");
        /// <summary>
        /// Constant DISCONTINUED for CatalogItemStatus
        /// </summary>
        public static readonly CatalogItemStatus DISCONTINUED = new CatalogItemStatus("DISCONTINUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CatalogItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CatalogItemStatus FindValue(string value)
        {
            return FindValue<CatalogItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CatalogItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeAssetState.
    /// </summary>
    public class ComputeAssetState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ComputeAssetState
        /// </summary>
        public static readonly ComputeAssetState ACTIVE = new ComputeAssetState("ACTIVE");
        /// <summary>
        /// Constant ISOLATED for ComputeAssetState
        /// </summary>
        public static readonly ComputeAssetState ISOLATED = new ComputeAssetState("ISOLATED");
        /// <summary>
        /// Constant RETIRING for ComputeAssetState
        /// </summary>
        public static readonly ComputeAssetState RETIRING = new ComputeAssetState("RETIRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeAssetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeAssetState FindValue(string value)
        {
            return FindValue<ComputeAssetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeAssetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FiberOpticCableType.
    /// </summary>
    public class FiberOpticCableType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_MODE for FiberOpticCableType
        /// </summary>
        public static readonly FiberOpticCableType MULTI_MODE = new FiberOpticCableType("MULTI_MODE");
        /// <summary>
        /// Constant SINGLE_MODE for FiberOpticCableType
        /// </summary>
        public static readonly FiberOpticCableType SINGLE_MODE = new FiberOpticCableType("SINGLE_MODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FiberOpticCableType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FiberOpticCableType FindValue(string value)
        {
            return FindValue<FiberOpticCableType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FiberOpticCableType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineItemStatus.
    /// </summary>
    public class LineItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant BUILDING for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus BUILDING = new LineItemStatus("BUILDING");
        /// <summary>
        /// Constant CANCELLED for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus CANCELLED = new LineItemStatus("CANCELLED");
        /// <summary>
        /// Constant DELIVERED for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus DELIVERED = new LineItemStatus("DELIVERED");
        /// <summary>
        /// Constant ERROR for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus ERROR = new LineItemStatus("ERROR");
        /// <summary>
        /// Constant INSTALLED for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus INSTALLED = new LineItemStatus("INSTALLED");
        /// <summary>
        /// Constant INSTALLING for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus INSTALLING = new LineItemStatus("INSTALLING");
        /// <summary>
        /// Constant PREPARING for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus PREPARING = new LineItemStatus("PREPARING");
        /// <summary>
        /// Constant SHIPPED for LineItemStatus
        /// </summary>
        public static readonly LineItemStatus SHIPPED = new LineItemStatus("SHIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineItemStatus FindValue(string value)
        {
            return FindValue<LineItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaximumSupportedWeightLbs.
    /// </summary>
    public class MaximumSupportedWeightLbs : ConstantClass
    {

        /// <summary>
        /// Constant MAX_1400_LBS for MaximumSupportedWeightLbs
        /// </summary>
        public static readonly MaximumSupportedWeightLbs MAX_1400_LBS = new MaximumSupportedWeightLbs("MAX_1400_LBS");
        /// <summary>
        /// Constant MAX_1600_LBS for MaximumSupportedWeightLbs
        /// </summary>
        public static readonly MaximumSupportedWeightLbs MAX_1600_LBS = new MaximumSupportedWeightLbs("MAX_1600_LBS");
        /// <summary>
        /// Constant MAX_1800_LBS for MaximumSupportedWeightLbs
        /// </summary>
        public static readonly MaximumSupportedWeightLbs MAX_1800_LBS = new MaximumSupportedWeightLbs("MAX_1800_LBS");
        /// <summary>
        /// Constant MAX_2000_LBS for MaximumSupportedWeightLbs
        /// </summary>
        public static readonly MaximumSupportedWeightLbs MAX_2000_LBS = new MaximumSupportedWeightLbs("MAX_2000_LBS");
        /// <summary>
        /// Constant NO_LIMIT for MaximumSupportedWeightLbs
        /// </summary>
        public static readonly MaximumSupportedWeightLbs NO_LIMIT = new MaximumSupportedWeightLbs("NO_LIMIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaximumSupportedWeightLbs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaximumSupportedWeightLbs FindValue(string value)
        {
            return FindValue<MaximumSupportedWeightLbs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaximumSupportedWeightLbs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpticalStandard.
    /// </summary>
    public class OpticalStandard : ConstantClass
    {

        /// <summary>
        /// Constant OPTIC_1000BASE_LX for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_1000BASE_LX = new OpticalStandard("OPTIC_1000BASE_LX");
        /// <summary>
        /// Constant OPTIC_1000BASE_SX for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_1000BASE_SX = new OpticalStandard("OPTIC_1000BASE_SX");
        /// <summary>
        /// Constant OPTIC_100G_PSM4_MSA for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_100G_PSM4_MSA = new OpticalStandard("OPTIC_100G_PSM4_MSA");
        /// <summary>
        /// Constant OPTIC_100GBASE_CWDM4 for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_100GBASE_CWDM4 = new OpticalStandard("OPTIC_100GBASE_CWDM4");
        /// <summary>
        /// Constant OPTIC_100GBASE_LR4 for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_100GBASE_LR4 = new OpticalStandard("OPTIC_100GBASE_LR4");
        /// <summary>
        /// Constant OPTIC_100GBASE_SR4 for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_100GBASE_SR4 = new OpticalStandard("OPTIC_100GBASE_SR4");
        /// <summary>
        /// Constant OPTIC_10GBASE_IR for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_10GBASE_IR = new OpticalStandard("OPTIC_10GBASE_IR");
        /// <summary>
        /// Constant OPTIC_10GBASE_LR for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_10GBASE_LR = new OpticalStandard("OPTIC_10GBASE_LR");
        /// <summary>
        /// Constant OPTIC_10GBASE_SR for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_10GBASE_SR = new OpticalStandard("OPTIC_10GBASE_SR");
        /// <summary>
        /// Constant OPTIC_40GBASE_ESR for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_40GBASE_ESR = new OpticalStandard("OPTIC_40GBASE_ESR");
        /// <summary>
        /// Constant OPTIC_40GBASE_IR4_LR4L for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_40GBASE_IR4_LR4L = new OpticalStandard("OPTIC_40GBASE_IR4_LR4L");
        /// <summary>
        /// Constant OPTIC_40GBASE_LR4 for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_40GBASE_LR4 = new OpticalStandard("OPTIC_40GBASE_LR4");
        /// <summary>
        /// Constant OPTIC_40GBASE_SR for OpticalStandard
        /// </summary>
        public static readonly OpticalStandard OPTIC_40GBASE_SR = new OpticalStandard("OPTIC_40GBASE_SR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpticalStandard(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpticalStandard FindValue(string value)
        {
            return FindValue<OpticalStandard>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpticalStandard(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderStatus.
    /// </summary>
    public class OrderStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for OrderStatus
        /// </summary>
        public static readonly OrderStatus CANCELLED = new OrderStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for OrderStatus
        /// </summary>
        public static readonly OrderStatus COMPLETED = new OrderStatus("COMPLETED");
        /// <summary>
        /// Constant ERROR for OrderStatus
        /// </summary>
        public static readonly OrderStatus ERROR = new OrderStatus("ERROR");
        /// <summary>
        /// Constant FULFILLED for OrderStatus
        /// </summary>
        public static readonly OrderStatus FULFILLED = new OrderStatus("FULFILLED");
        /// <summary>
        /// Constant IN_PROGRESS for OrderStatus
        /// </summary>
        public static readonly OrderStatus IN_PROGRESS = new OrderStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INSTALLING for OrderStatus
        /// </summary>
        public static readonly OrderStatus INSTALLING = new OrderStatus("INSTALLING");
        /// <summary>
        /// Constant PENDING for OrderStatus
        /// </summary>
        public static readonly OrderStatus PENDING = new OrderStatus("PENDING");
        /// <summary>
        /// Constant PREPARING for OrderStatus
        /// </summary>
        public static readonly OrderStatus PREPARING = new OrderStatus("PREPARING");
        /// <summary>
        /// Constant PROCESSING for OrderStatus
        /// </summary>
        public static readonly OrderStatus PROCESSING = new OrderStatus("PROCESSING");
        /// <summary>
        /// Constant RECEIVED for OrderStatus
        /// </summary>
        public static readonly OrderStatus RECEIVED = new OrderStatus("RECEIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderStatus FindValue(string value)
        {
            return FindValue<OrderStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderType.
    /// </summary>
    public class OrderType : ConstantClass
    {

        /// <summary>
        /// Constant OUTPOST for OrderType
        /// </summary>
        public static readonly OrderType OUTPOST = new OrderType("OUTPOST");
        /// <summary>
        /// Constant REPLACEMENT for OrderType
        /// </summary>
        public static readonly OrderType REPLACEMENT = new OrderType("REPLACEMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderType FindValue(string value)
        {
            return FindValue<OrderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentOption.
    /// </summary>
    public class PaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption ALL_UPFRONT = new PaymentOption("ALL_UPFRONT");
        /// <summary>
        /// Constant NO_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption NO_UPFRONT = new PaymentOption("NO_UPFRONT");
        /// <summary>
        /// Constant PARTIAL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption PARTIAL_UPFRONT = new PaymentOption("PARTIAL_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentOption FindValue(string value)
        {
            return FindValue<PaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentTerm.
    /// </summary>
    public class PaymentTerm : ConstantClass
    {

        /// <summary>
        /// Constant ONE_YEAR for PaymentTerm
        /// </summary>
        public static readonly PaymentTerm ONE_YEAR = new PaymentTerm("ONE_YEAR");
        /// <summary>
        /// Constant THREE_YEARS for PaymentTerm
        /// </summary>
        public static readonly PaymentTerm THREE_YEARS = new PaymentTerm("THREE_YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentTerm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentTerm FindValue(string value)
        {
            return FindValue<PaymentTerm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentTerm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PowerConnector.
    /// </summary>
    public class PowerConnector : ConstantClass
    {

        /// <summary>
        /// Constant AH530P7W for PowerConnector
        /// </summary>
        public static readonly PowerConnector AH530P7W = new PowerConnector("AH530P7W");
        /// <summary>
        /// Constant AH532P6W for PowerConnector
        /// </summary>
        public static readonly PowerConnector AH532P6W = new PowerConnector("AH532P6W");
        /// <summary>
        /// Constant IEC309 for PowerConnector
        /// </summary>
        public static readonly PowerConnector IEC309 = new PowerConnector("IEC309");
        /// <summary>
        /// Constant L6_30P for PowerConnector
        /// </summary>
        public static readonly PowerConnector L6_30P = new PowerConnector("L6_30P");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PowerConnector(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PowerConnector FindValue(string value)
        {
            return FindValue<PowerConnector>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PowerConnector(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PowerDrawKva.
    /// </summary>
    public class PowerDrawKva : ConstantClass
    {

        /// <summary>
        /// Constant POWER_10_KVA for PowerDrawKva
        /// </summary>
        public static readonly PowerDrawKva POWER_10_KVA = new PowerDrawKva("POWER_10_KVA");
        /// <summary>
        /// Constant POWER_15_KVA for PowerDrawKva
        /// </summary>
        public static readonly PowerDrawKva POWER_15_KVA = new PowerDrawKva("POWER_15_KVA");
        /// <summary>
        /// Constant POWER_30_KVA for PowerDrawKva
        /// </summary>
        public static readonly PowerDrawKva POWER_30_KVA = new PowerDrawKva("POWER_30_KVA");
        /// <summary>
        /// Constant POWER_5_KVA for PowerDrawKva
        /// </summary>
        public static readonly PowerDrawKva POWER_5_KVA = new PowerDrawKva("POWER_5_KVA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PowerDrawKva(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PowerDrawKva FindValue(string value)
        {
            return FindValue<PowerDrawKva>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PowerDrawKva(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PowerFeedDrop.
    /// </summary>
    public class PowerFeedDrop : ConstantClass
    {

        /// <summary>
        /// Constant ABOVE_RACK for PowerFeedDrop
        /// </summary>
        public static readonly PowerFeedDrop ABOVE_RACK = new PowerFeedDrop("ABOVE_RACK");
        /// <summary>
        /// Constant BELOW_RACK for PowerFeedDrop
        /// </summary>
        public static readonly PowerFeedDrop BELOW_RACK = new PowerFeedDrop("BELOW_RACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PowerFeedDrop(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PowerFeedDrop FindValue(string value)
        {
            return FindValue<PowerFeedDrop>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PowerFeedDrop(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PowerPhase.
    /// </summary>
    public class PowerPhase : ConstantClass
    {

        /// <summary>
        /// Constant SINGLE_PHASE for PowerPhase
        /// </summary>
        public static readonly PowerPhase SINGLE_PHASE = new PowerPhase("SINGLE_PHASE");
        /// <summary>
        /// Constant THREE_PHASE for PowerPhase
        /// </summary>
        public static readonly PowerPhase THREE_PHASE = new PowerPhase("THREE_PHASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PowerPhase(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PowerPhase FindValue(string value)
        {
            return FindValue<PowerPhase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PowerPhase(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ORDER for ResourceType
        /// </summary>
        public static readonly ResourceType ORDER = new ResourceType("ORDER");
        /// <summary>
        /// Constant OUTPOST for ResourceType
        /// </summary>
        public static readonly ResourceType OUTPOST = new ResourceType("OUTPOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShipmentCarrier.
    /// </summary>
    public class ShipmentCarrier : ConstantClass
    {

        /// <summary>
        /// Constant DBS for ShipmentCarrier
        /// </summary>
        public static readonly ShipmentCarrier DBS = new ShipmentCarrier("DBS");
        /// <summary>
        /// Constant DHL for ShipmentCarrier
        /// </summary>
        public static readonly ShipmentCarrier DHL = new ShipmentCarrier("DHL");
        /// <summary>
        /// Constant FEDEX for ShipmentCarrier
        /// </summary>
        public static readonly ShipmentCarrier FEDEX = new ShipmentCarrier("FEDEX");
        /// <summary>
        /// Constant UPS for ShipmentCarrier
        /// </summary>
        public static readonly ShipmentCarrier UPS = new ShipmentCarrier("UPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShipmentCarrier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShipmentCarrier FindValue(string value)
        {
            return FindValue<ShipmentCarrier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShipmentCarrier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupportedHardwareType.
    /// </summary>
    public class SupportedHardwareType : ConstantClass
    {

        /// <summary>
        /// Constant RACK for SupportedHardwareType
        /// </summary>
        public static readonly SupportedHardwareType RACK = new SupportedHardwareType("RACK");
        /// <summary>
        /// Constant SERVER for SupportedHardwareType
        /// </summary>
        public static readonly SupportedHardwareType SERVER = new SupportedHardwareType("SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportedHardwareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportedHardwareType FindValue(string value)
        {
            return FindValue<SupportedHardwareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportedHardwareType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupportedStorageEnum.
    /// </summary>
    public class SupportedStorageEnum : ConstantClass
    {

        /// <summary>
        /// Constant EBS for SupportedStorageEnum
        /// </summary>
        public static readonly SupportedStorageEnum EBS = new SupportedStorageEnum("EBS");
        /// <summary>
        /// Constant S3 for SupportedStorageEnum
        /// </summary>
        public static readonly SupportedStorageEnum S3 = new SupportedStorageEnum("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportedStorageEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportedStorageEnum FindValue(string value)
        {
            return FindValue<SupportedStorageEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportedStorageEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UplinkCount.
    /// </summary>
    public class UplinkCount : ConstantClass
    {

        /// <summary>
        /// Constant UPLINK_COUNT_1 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_1 = new UplinkCount("UPLINK_COUNT_1");
        /// <summary>
        /// Constant UPLINK_COUNT_12 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_12 = new UplinkCount("UPLINK_COUNT_12");
        /// <summary>
        /// Constant UPLINK_COUNT_16 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_16 = new UplinkCount("UPLINK_COUNT_16");
        /// <summary>
        /// Constant UPLINK_COUNT_2 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_2 = new UplinkCount("UPLINK_COUNT_2");
        /// <summary>
        /// Constant UPLINK_COUNT_3 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_3 = new UplinkCount("UPLINK_COUNT_3");
        /// <summary>
        /// Constant UPLINK_COUNT_4 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_4 = new UplinkCount("UPLINK_COUNT_4");
        /// <summary>
        /// Constant UPLINK_COUNT_5 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_5 = new UplinkCount("UPLINK_COUNT_5");
        /// <summary>
        /// Constant UPLINK_COUNT_6 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_6 = new UplinkCount("UPLINK_COUNT_6");
        /// <summary>
        /// Constant UPLINK_COUNT_7 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_7 = new UplinkCount("UPLINK_COUNT_7");
        /// <summary>
        /// Constant UPLINK_COUNT_8 for UplinkCount
        /// </summary>
        public static readonly UplinkCount UPLINK_COUNT_8 = new UplinkCount("UPLINK_COUNT_8");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UplinkCount(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UplinkCount FindValue(string value)
        {
            return FindValue<UplinkCount>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UplinkCount(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UplinkGbps.
    /// </summary>
    public class UplinkGbps : ConstantClass
    {

        /// <summary>
        /// Constant UPLINK_100G for UplinkGbps
        /// </summary>
        public static readonly UplinkGbps UPLINK_100G = new UplinkGbps("UPLINK_100G");
        /// <summary>
        /// Constant UPLINK_10G for UplinkGbps
        /// </summary>
        public static readonly UplinkGbps UPLINK_10G = new UplinkGbps("UPLINK_10G");
        /// <summary>
        /// Constant UPLINK_1G for UplinkGbps
        /// </summary>
        public static readonly UplinkGbps UPLINK_1G = new UplinkGbps("UPLINK_1G");
        /// <summary>
        /// Constant UPLINK_40G for UplinkGbps
        /// </summary>
        public static readonly UplinkGbps UPLINK_40G = new UplinkGbps("UPLINK_40G");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UplinkGbps(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UplinkGbps FindValue(string value)
        {
            return FindValue<UplinkGbps>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UplinkGbps(string value)
        {
            return FindValue(value);
        }
    }

}