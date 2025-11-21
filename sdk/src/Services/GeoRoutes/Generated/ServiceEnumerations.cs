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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GeoRoutes
{

    /// <summary>
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant Friday for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek Friday = new DayOfWeek("Friday");
        /// <summary>
        /// Constant Monday for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek Monday = new DayOfWeek("Monday");
        /// <summary>
        /// Constant Saturday for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek Saturday = new DayOfWeek("Saturday");
        /// <summary>
        /// Constant Sunday for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek Sunday = new DayOfWeek("Sunday");
        /// <summary>
        /// Constant Thursday for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek Thursday = new DayOfWeek("Thursday");
        /// <summary>
        /// Constant Tuesday for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek Tuesday = new DayOfWeek("Tuesday");
        /// <summary>
        /// Constant Wednesday for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek Wednesday = new DayOfWeek("Wednesday");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeometryFormat.
    /// </summary>
    public class GeometryFormat : ConstantClass
    {

        /// <summary>
        /// Constant FlexiblePolyline for GeometryFormat
        /// </summary>
        public static readonly GeometryFormat FlexiblePolyline = new GeometryFormat("FlexiblePolyline");
        /// <summary>
        /// Constant Simple for GeometryFormat
        /// </summary>
        public static readonly GeometryFormat Simple = new GeometryFormat("Simple");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeometryFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeometryFormat FindValue(string value)
        {
            return FindValue<GeometryFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeometryFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsolineEngineType.
    /// </summary>
    public class IsolineEngineType : ConstantClass
    {

        /// <summary>
        /// Constant Electric for IsolineEngineType
        /// </summary>
        public static readonly IsolineEngineType Electric = new IsolineEngineType("Electric");
        /// <summary>
        /// Constant InternalCombustion for IsolineEngineType
        /// </summary>
        public static readonly IsolineEngineType InternalCombustion = new IsolineEngineType("InternalCombustion");
        /// <summary>
        /// Constant PluginHybrid for IsolineEngineType
        /// </summary>
        public static readonly IsolineEngineType PluginHybrid = new IsolineEngineType("PluginHybrid");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsolineEngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsolineEngineType FindValue(string value)
        {
            return FindValue<IsolineEngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsolineEngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsolineHazardousCargoType.
    /// </summary>
    public class IsolineHazardousCargoType : ConstantClass
    {

        /// <summary>
        /// Constant Combustible for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Combustible = new IsolineHazardousCargoType("Combustible");
        /// <summary>
        /// Constant Corrosive for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Corrosive = new IsolineHazardousCargoType("Corrosive");
        /// <summary>
        /// Constant Explosive for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Explosive = new IsolineHazardousCargoType("Explosive");
        /// <summary>
        /// Constant Flammable for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Flammable = new IsolineHazardousCargoType("Flammable");
        /// <summary>
        /// Constant Gas for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Gas = new IsolineHazardousCargoType("Gas");
        /// <summary>
        /// Constant HarmfulToWater for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType HarmfulToWater = new IsolineHazardousCargoType("HarmfulToWater");
        /// <summary>
        /// Constant Organic for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Organic = new IsolineHazardousCargoType("Organic");
        /// <summary>
        /// Constant Other for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Other = new IsolineHazardousCargoType("Other");
        /// <summary>
        /// Constant Poison for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Poison = new IsolineHazardousCargoType("Poison");
        /// <summary>
        /// Constant PoisonousInhalation for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType PoisonousInhalation = new IsolineHazardousCargoType("PoisonousInhalation");
        /// <summary>
        /// Constant Radioactive for IsolineHazardousCargoType
        /// </summary>
        public static readonly IsolineHazardousCargoType Radioactive = new IsolineHazardousCargoType("Radioactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsolineHazardousCargoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsolineHazardousCargoType FindValue(string value)
        {
            return FindValue<IsolineHazardousCargoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsolineHazardousCargoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsolineOptimizationObjective.
    /// </summary>
    public class IsolineOptimizationObjective : ConstantClass
    {

        /// <summary>
        /// Constant AccurateCalculation for IsolineOptimizationObjective
        /// </summary>
        public static readonly IsolineOptimizationObjective AccurateCalculation = new IsolineOptimizationObjective("AccurateCalculation");
        /// <summary>
        /// Constant BalancedCalculation for IsolineOptimizationObjective
        /// </summary>
        public static readonly IsolineOptimizationObjective BalancedCalculation = new IsolineOptimizationObjective("BalancedCalculation");
        /// <summary>
        /// Constant FastCalculation for IsolineOptimizationObjective
        /// </summary>
        public static readonly IsolineOptimizationObjective FastCalculation = new IsolineOptimizationObjective("FastCalculation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsolineOptimizationObjective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsolineOptimizationObjective FindValue(string value)
        {
            return FindValue<IsolineOptimizationObjective>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsolineOptimizationObjective(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsolineTravelMode.
    /// </summary>
    public class IsolineTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for IsolineTravelMode
        /// </summary>
        public static readonly IsolineTravelMode Car = new IsolineTravelMode("Car");
        /// <summary>
        /// Constant Pedestrian for IsolineTravelMode
        /// </summary>
        public static readonly IsolineTravelMode Pedestrian = new IsolineTravelMode("Pedestrian");
        /// <summary>
        /// Constant Scooter for IsolineTravelMode
        /// </summary>
        public static readonly IsolineTravelMode Scooter = new IsolineTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for IsolineTravelMode
        /// </summary>
        public static readonly IsolineTravelMode Truck = new IsolineTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsolineTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsolineTravelMode FindValue(string value)
        {
            return FindValue<IsolineTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsolineTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsolineTruckType.
    /// </summary>
    public class IsolineTruckType : ConstantClass
    {

        /// <summary>
        /// Constant LightTruck for IsolineTruckType
        /// </summary>
        public static readonly IsolineTruckType LightTruck = new IsolineTruckType("LightTruck");
        /// <summary>
        /// Constant StraightTruck for IsolineTruckType
        /// </summary>
        public static readonly IsolineTruckType StraightTruck = new IsolineTruckType("StraightTruck");
        /// <summary>
        /// Constant Tractor for IsolineTruckType
        /// </summary>
        public static readonly IsolineTruckType Tractor = new IsolineTruckType("Tractor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsolineTruckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsolineTruckType FindValue(string value)
        {
            return FindValue<IsolineTruckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsolineTruckType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsolineZoneCategory.
    /// </summary>
    public class IsolineZoneCategory : ConstantClass
    {

        /// <summary>
        /// Constant CongestionPricing for IsolineZoneCategory
        /// </summary>
        public static readonly IsolineZoneCategory CongestionPricing = new IsolineZoneCategory("CongestionPricing");
        /// <summary>
        /// Constant Environmental for IsolineZoneCategory
        /// </summary>
        public static readonly IsolineZoneCategory Environmental = new IsolineZoneCategory("Environmental");
        /// <summary>
        /// Constant Vignette for IsolineZoneCategory
        /// </summary>
        public static readonly IsolineZoneCategory Vignette = new IsolineZoneCategory("Vignette");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsolineZoneCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsolineZoneCategory FindValue(string value)
        {
            return FindValue<IsolineZoneCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsolineZoneCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchingStrategy.
    /// </summary>
    public class MatchingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant MatchAny for MatchingStrategy
        /// </summary>
        public static readonly MatchingStrategy MatchAny = new MatchingStrategy("MatchAny");
        /// <summary>
        /// Constant MatchMostSignificantRoad for MatchingStrategy
        /// </summary>
        public static readonly MatchingStrategy MatchMostSignificantRoad = new MatchingStrategy("MatchMostSignificantRoad");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchingStrategy FindValue(string value)
        {
            return FindValue<MatchingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MeasurementSystem.
    /// </summary>
    public class MeasurementSystem : ConstantClass
    {

        /// <summary>
        /// Constant Imperial for MeasurementSystem
        /// </summary>
        public static readonly MeasurementSystem Imperial = new MeasurementSystem("Imperial");
        /// <summary>
        /// Constant Metric for MeasurementSystem
        /// </summary>
        public static readonly MeasurementSystem Metric = new MeasurementSystem("Metric");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MeasurementSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MeasurementSystem FindValue(string value)
        {
            return FindValue<MeasurementSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MeasurementSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoadSnapHazardousCargoType.
    /// </summary>
    public class RoadSnapHazardousCargoType : ConstantClass
    {

        /// <summary>
        /// Constant Combustible for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Combustible = new RoadSnapHazardousCargoType("Combustible");
        /// <summary>
        /// Constant Corrosive for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Corrosive = new RoadSnapHazardousCargoType("Corrosive");
        /// <summary>
        /// Constant Explosive for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Explosive = new RoadSnapHazardousCargoType("Explosive");
        /// <summary>
        /// Constant Flammable for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Flammable = new RoadSnapHazardousCargoType("Flammable");
        /// <summary>
        /// Constant Gas for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Gas = new RoadSnapHazardousCargoType("Gas");
        /// <summary>
        /// Constant HarmfulToWater for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType HarmfulToWater = new RoadSnapHazardousCargoType("HarmfulToWater");
        /// <summary>
        /// Constant Organic for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Organic = new RoadSnapHazardousCargoType("Organic");
        /// <summary>
        /// Constant Other for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Other = new RoadSnapHazardousCargoType("Other");
        /// <summary>
        /// Constant Poison for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Poison = new RoadSnapHazardousCargoType("Poison");
        /// <summary>
        /// Constant PoisonousInhalation for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType PoisonousInhalation = new RoadSnapHazardousCargoType("PoisonousInhalation");
        /// <summary>
        /// Constant Radioactive for RoadSnapHazardousCargoType
        /// </summary>
        public static readonly RoadSnapHazardousCargoType Radioactive = new RoadSnapHazardousCargoType("Radioactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoadSnapHazardousCargoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoadSnapHazardousCargoType FindValue(string value)
        {
            return FindValue<RoadSnapHazardousCargoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoadSnapHazardousCargoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoadSnapNoticeCode.
    /// </summary>
    public class RoadSnapNoticeCode : ConstantClass
    {

        /// <summary>
        /// Constant TracePointsHeadingIgnored for RoadSnapNoticeCode
        /// </summary>
        public static readonly RoadSnapNoticeCode TracePointsHeadingIgnored = new RoadSnapNoticeCode("TracePointsHeadingIgnored");
        /// <summary>
        /// Constant TracePointsIgnored for RoadSnapNoticeCode
        /// </summary>
        public static readonly RoadSnapNoticeCode TracePointsIgnored = new RoadSnapNoticeCode("TracePointsIgnored");
        /// <summary>
        /// Constant TracePointsMovedByLargeDistance for RoadSnapNoticeCode
        /// </summary>
        public static readonly RoadSnapNoticeCode TracePointsMovedByLargeDistance = new RoadSnapNoticeCode("TracePointsMovedByLargeDistance");
        /// <summary>
        /// Constant TracePointsNotMatched for RoadSnapNoticeCode
        /// </summary>
        public static readonly RoadSnapNoticeCode TracePointsNotMatched = new RoadSnapNoticeCode("TracePointsNotMatched");
        /// <summary>
        /// Constant TracePointsOutOfSequence for RoadSnapNoticeCode
        /// </summary>
        public static readonly RoadSnapNoticeCode TracePointsOutOfSequence = new RoadSnapNoticeCode("TracePointsOutOfSequence");
        /// <summary>
        /// Constant TracePointsSpeedEstimated for RoadSnapNoticeCode
        /// </summary>
        public static readonly RoadSnapNoticeCode TracePointsSpeedEstimated = new RoadSnapNoticeCode("TracePointsSpeedEstimated");
        /// <summary>
        /// Constant TracePointsSpeedIgnored for RoadSnapNoticeCode
        /// </summary>
        public static readonly RoadSnapNoticeCode TracePointsSpeedIgnored = new RoadSnapNoticeCode("TracePointsSpeedIgnored");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoadSnapNoticeCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoadSnapNoticeCode FindValue(string value)
        {
            return FindValue<RoadSnapNoticeCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoadSnapNoticeCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoadSnapTravelMode.
    /// </summary>
    public class RoadSnapTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for RoadSnapTravelMode
        /// </summary>
        public static readonly RoadSnapTravelMode Car = new RoadSnapTravelMode("Car");
        /// <summary>
        /// Constant Pedestrian for RoadSnapTravelMode
        /// </summary>
        public static readonly RoadSnapTravelMode Pedestrian = new RoadSnapTravelMode("Pedestrian");
        /// <summary>
        /// Constant Scooter for RoadSnapTravelMode
        /// </summary>
        public static readonly RoadSnapTravelMode Scooter = new RoadSnapTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for RoadSnapTravelMode
        /// </summary>
        public static readonly RoadSnapTravelMode Truck = new RoadSnapTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoadSnapTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoadSnapTravelMode FindValue(string value)
        {
            return FindValue<RoadSnapTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoadSnapTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteDirection.
    /// </summary>
    public class RouteDirection : ConstantClass
    {

        /// <summary>
        /// Constant East for RouteDirection
        /// </summary>
        public static readonly RouteDirection East = new RouteDirection("East");
        /// <summary>
        /// Constant North for RouteDirection
        /// </summary>
        public static readonly RouteDirection North = new RouteDirection("North");
        /// <summary>
        /// Constant South for RouteDirection
        /// </summary>
        public static readonly RouteDirection South = new RouteDirection("South");
        /// <summary>
        /// Constant West for RouteDirection
        /// </summary>
        public static readonly RouteDirection West = new RouteDirection("West");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteDirection FindValue(string value)
        {
            return FindValue<RouteDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteEngineType.
    /// </summary>
    public class RouteEngineType : ConstantClass
    {

        /// <summary>
        /// Constant Electric for RouteEngineType
        /// </summary>
        public static readonly RouteEngineType Electric = new RouteEngineType("Electric");
        /// <summary>
        /// Constant InternalCombustion for RouteEngineType
        /// </summary>
        public static readonly RouteEngineType InternalCombustion = new RouteEngineType("InternalCombustion");
        /// <summary>
        /// Constant PluginHybrid for RouteEngineType
        /// </summary>
        public static readonly RouteEngineType PluginHybrid = new RouteEngineType("PluginHybrid");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteEngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteEngineType FindValue(string value)
        {
            return FindValue<RouteEngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteEngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteFerryAfterTravelStepType.
    /// </summary>
    public class RouteFerryAfterTravelStepType : ConstantClass
    {

        /// <summary>
        /// Constant Deboard for RouteFerryAfterTravelStepType
        /// </summary>
        public static readonly RouteFerryAfterTravelStepType Deboard = new RouteFerryAfterTravelStepType("Deboard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteFerryAfterTravelStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteFerryAfterTravelStepType FindValue(string value)
        {
            return FindValue<RouteFerryAfterTravelStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteFerryAfterTravelStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteFerryBeforeTravelStepType.
    /// </summary>
    public class RouteFerryBeforeTravelStepType : ConstantClass
    {

        /// <summary>
        /// Constant Board for RouteFerryBeforeTravelStepType
        /// </summary>
        public static readonly RouteFerryBeforeTravelStepType Board = new RouteFerryBeforeTravelStepType("Board");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteFerryBeforeTravelStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteFerryBeforeTravelStepType FindValue(string value)
        {
            return FindValue<RouteFerryBeforeTravelStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteFerryBeforeTravelStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteFerryNoticeCode.
    /// </summary>
    public class RouteFerryNoticeCode : ConstantClass
    {

        /// <summary>
        /// Constant AccuratePolylineUnavailable for RouteFerryNoticeCode
        /// </summary>
        public static readonly RouteFerryNoticeCode AccuratePolylineUnavailable = new RouteFerryNoticeCode("AccuratePolylineUnavailable");
        /// <summary>
        /// Constant NoSchedule for RouteFerryNoticeCode
        /// </summary>
        public static readonly RouteFerryNoticeCode NoSchedule = new RouteFerryNoticeCode("NoSchedule");
        /// <summary>
        /// Constant Other for RouteFerryNoticeCode
        /// </summary>
        public static readonly RouteFerryNoticeCode Other = new RouteFerryNoticeCode("Other");
        /// <summary>
        /// Constant PotentialViolatedVehicleRestrictionUsage for RouteFerryNoticeCode
        /// </summary>
        public static readonly RouteFerryNoticeCode PotentialViolatedVehicleRestrictionUsage = new RouteFerryNoticeCode("PotentialViolatedVehicleRestrictionUsage");
        /// <summary>
        /// Constant SeasonalClosure for RouteFerryNoticeCode
        /// </summary>
        public static readonly RouteFerryNoticeCode SeasonalClosure = new RouteFerryNoticeCode("SeasonalClosure");
        /// <summary>
        /// Constant ViolatedAvoidFerry for RouteFerryNoticeCode
        /// </summary>
        public static readonly RouteFerryNoticeCode ViolatedAvoidFerry = new RouteFerryNoticeCode("ViolatedAvoidFerry");
        /// <summary>
        /// Constant ViolatedAvoidRailFerry for RouteFerryNoticeCode
        /// </summary>
        public static readonly RouteFerryNoticeCode ViolatedAvoidRailFerry = new RouteFerryNoticeCode("ViolatedAvoidRailFerry");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteFerryNoticeCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteFerryNoticeCode FindValue(string value)
        {
            return FindValue<RouteFerryNoticeCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteFerryNoticeCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteFerryTravelStepType.
    /// </summary>
    public class RouteFerryTravelStepType : ConstantClass
    {

        /// <summary>
        /// Constant Arrive for RouteFerryTravelStepType
        /// </summary>
        public static readonly RouteFerryTravelStepType Arrive = new RouteFerryTravelStepType("Arrive");
        /// <summary>
        /// Constant Continue for RouteFerryTravelStepType
        /// </summary>
        public static readonly RouteFerryTravelStepType Continue = new RouteFerryTravelStepType("Continue");
        /// <summary>
        /// Constant Depart for RouteFerryTravelStepType
        /// </summary>
        public static readonly RouteFerryTravelStepType Depart = new RouteFerryTravelStepType("Depart");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteFerryTravelStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteFerryTravelStepType FindValue(string value)
        {
            return FindValue<RouteFerryTravelStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteFerryTravelStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteHazardousCargoType.
    /// </summary>
    public class RouteHazardousCargoType : ConstantClass
    {

        /// <summary>
        /// Constant Combustible for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Combustible = new RouteHazardousCargoType("Combustible");
        /// <summary>
        /// Constant Corrosive for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Corrosive = new RouteHazardousCargoType("Corrosive");
        /// <summary>
        /// Constant Explosive for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Explosive = new RouteHazardousCargoType("Explosive");
        /// <summary>
        /// Constant Flammable for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Flammable = new RouteHazardousCargoType("Flammable");
        /// <summary>
        /// Constant Gas for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Gas = new RouteHazardousCargoType("Gas");
        /// <summary>
        /// Constant HarmfulToWater for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType HarmfulToWater = new RouteHazardousCargoType("HarmfulToWater");
        /// <summary>
        /// Constant Organic for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Organic = new RouteHazardousCargoType("Organic");
        /// <summary>
        /// Constant Other for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Other = new RouteHazardousCargoType("Other");
        /// <summary>
        /// Constant Poison for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Poison = new RouteHazardousCargoType("Poison");
        /// <summary>
        /// Constant PoisonousInhalation for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType PoisonousInhalation = new RouteHazardousCargoType("PoisonousInhalation");
        /// <summary>
        /// Constant Radioactive for RouteHazardousCargoType
        /// </summary>
        public static readonly RouteHazardousCargoType Radioactive = new RouteHazardousCargoType("Radioactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteHazardousCargoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteHazardousCargoType FindValue(string value)
        {
            return FindValue<RouteHazardousCargoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteHazardousCargoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteLegAdditionalFeature.
    /// </summary>
    public class RouteLegAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant Elevation for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature Elevation = new RouteLegAdditionalFeature("Elevation");
        /// <summary>
        /// Constant Incidents for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature Incidents = new RouteLegAdditionalFeature("Incidents");
        /// <summary>
        /// Constant PassThroughWaypoints for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature PassThroughWaypoints = new RouteLegAdditionalFeature("PassThroughWaypoints");
        /// <summary>
        /// Constant Summary for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature Summary = new RouteLegAdditionalFeature("Summary");
        /// <summary>
        /// Constant Tolls for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature Tolls = new RouteLegAdditionalFeature("Tolls");
        /// <summary>
        /// Constant TravelStepInstructions for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature TravelStepInstructions = new RouteLegAdditionalFeature("TravelStepInstructions");
        /// <summary>
        /// Constant TruckRoadTypes for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature TruckRoadTypes = new RouteLegAdditionalFeature("TruckRoadTypes");
        /// <summary>
        /// Constant TypicalDuration for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature TypicalDuration = new RouteLegAdditionalFeature("TypicalDuration");
        /// <summary>
        /// Constant Zones for RouteLegAdditionalFeature
        /// </summary>
        public static readonly RouteLegAdditionalFeature Zones = new RouteLegAdditionalFeature("Zones");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteLegAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteLegAdditionalFeature FindValue(string value)
        {
            return FindValue<RouteLegAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteLegAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteLegTravelMode.
    /// </summary>
    public class RouteLegTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for RouteLegTravelMode
        /// </summary>
        public static readonly RouteLegTravelMode Car = new RouteLegTravelMode("Car");
        /// <summary>
        /// Constant CarShuttleTrain for RouteLegTravelMode
        /// </summary>
        public static readonly RouteLegTravelMode CarShuttleTrain = new RouteLegTravelMode("CarShuttleTrain");
        /// <summary>
        /// Constant Ferry for RouteLegTravelMode
        /// </summary>
        public static readonly RouteLegTravelMode Ferry = new RouteLegTravelMode("Ferry");
        /// <summary>
        /// Constant Pedestrian for RouteLegTravelMode
        /// </summary>
        public static readonly RouteLegTravelMode Pedestrian = new RouteLegTravelMode("Pedestrian");
        /// <summary>
        /// Constant Scooter for RouteLegTravelMode
        /// </summary>
        public static readonly RouteLegTravelMode Scooter = new RouteLegTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for RouteLegTravelMode
        /// </summary>
        public static readonly RouteLegTravelMode Truck = new RouteLegTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteLegTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteLegTravelMode FindValue(string value)
        {
            return FindValue<RouteLegTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteLegTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteLegType.
    /// </summary>
    public class RouteLegType : ConstantClass
    {

        /// <summary>
        /// Constant Ferry for RouteLegType
        /// </summary>
        public static readonly RouteLegType Ferry = new RouteLegType("Ferry");
        /// <summary>
        /// Constant Pedestrian for RouteLegType
        /// </summary>
        public static readonly RouteLegType Pedestrian = new RouteLegType("Pedestrian");
        /// <summary>
        /// Constant Vehicle for RouteLegType
        /// </summary>
        public static readonly RouteLegType Vehicle = new RouteLegType("Vehicle");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteLegType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteLegType FindValue(string value)
        {
            return FindValue<RouteLegType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteLegType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteMatrixErrorCode.
    /// </summary>
    public class RouteMatrixErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant NoMatch for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode NoMatch = new RouteMatrixErrorCode("NoMatch");
        /// <summary>
        /// Constant NoMatchDestination for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode NoMatchDestination = new RouteMatrixErrorCode("NoMatchDestination");
        /// <summary>
        /// Constant NoMatchOrigin for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode NoMatchOrigin = new RouteMatrixErrorCode("NoMatchOrigin");
        /// <summary>
        /// Constant NoRoute for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode NoRoute = new RouteMatrixErrorCode("NoRoute");
        /// <summary>
        /// Constant Other for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode Other = new RouteMatrixErrorCode("Other");
        /// <summary>
        /// Constant OutOfBounds for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode OutOfBounds = new RouteMatrixErrorCode("OutOfBounds");
        /// <summary>
        /// Constant OutOfBoundsDestination for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode OutOfBoundsDestination = new RouteMatrixErrorCode("OutOfBoundsDestination");
        /// <summary>
        /// Constant OutOfBoundsOrigin for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode OutOfBoundsOrigin = new RouteMatrixErrorCode("OutOfBoundsOrigin");
        /// <summary>
        /// Constant Violation for RouteMatrixErrorCode
        /// </summary>
        public static readonly RouteMatrixErrorCode Violation = new RouteMatrixErrorCode("Violation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteMatrixErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteMatrixErrorCode FindValue(string value)
        {
            return FindValue<RouteMatrixErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteMatrixErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteMatrixHazardousCargoType.
    /// </summary>
    public class RouteMatrixHazardousCargoType : ConstantClass
    {

        /// <summary>
        /// Constant Combustible for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Combustible = new RouteMatrixHazardousCargoType("Combustible");
        /// <summary>
        /// Constant Corrosive for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Corrosive = new RouteMatrixHazardousCargoType("Corrosive");
        /// <summary>
        /// Constant Explosive for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Explosive = new RouteMatrixHazardousCargoType("Explosive");
        /// <summary>
        /// Constant Flammable for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Flammable = new RouteMatrixHazardousCargoType("Flammable");
        /// <summary>
        /// Constant Gas for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Gas = new RouteMatrixHazardousCargoType("Gas");
        /// <summary>
        /// Constant HarmfulToWater for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType HarmfulToWater = new RouteMatrixHazardousCargoType("HarmfulToWater");
        /// <summary>
        /// Constant Organic for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Organic = new RouteMatrixHazardousCargoType("Organic");
        /// <summary>
        /// Constant Other for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Other = new RouteMatrixHazardousCargoType("Other");
        /// <summary>
        /// Constant Poison for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Poison = new RouteMatrixHazardousCargoType("Poison");
        /// <summary>
        /// Constant PoisonousInhalation for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType PoisonousInhalation = new RouteMatrixHazardousCargoType("PoisonousInhalation");
        /// <summary>
        /// Constant Radioactive for RouteMatrixHazardousCargoType
        /// </summary>
        public static readonly RouteMatrixHazardousCargoType Radioactive = new RouteMatrixHazardousCargoType("Radioactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteMatrixHazardousCargoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteMatrixHazardousCargoType FindValue(string value)
        {
            return FindValue<RouteMatrixHazardousCargoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteMatrixHazardousCargoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteMatrixTravelMode.
    /// </summary>
    public class RouteMatrixTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for RouteMatrixTravelMode
        /// </summary>
        public static readonly RouteMatrixTravelMode Car = new RouteMatrixTravelMode("Car");
        /// <summary>
        /// Constant Pedestrian for RouteMatrixTravelMode
        /// </summary>
        public static readonly RouteMatrixTravelMode Pedestrian = new RouteMatrixTravelMode("Pedestrian");
        /// <summary>
        /// Constant Scooter for RouteMatrixTravelMode
        /// </summary>
        public static readonly RouteMatrixTravelMode Scooter = new RouteMatrixTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for RouteMatrixTravelMode
        /// </summary>
        public static readonly RouteMatrixTravelMode Truck = new RouteMatrixTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteMatrixTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteMatrixTravelMode FindValue(string value)
        {
            return FindValue<RouteMatrixTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteMatrixTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteMatrixTruckType.
    /// </summary>
    public class RouteMatrixTruckType : ConstantClass
    {

        /// <summary>
        /// Constant LightTruck for RouteMatrixTruckType
        /// </summary>
        public static readonly RouteMatrixTruckType LightTruck = new RouteMatrixTruckType("LightTruck");
        /// <summary>
        /// Constant StraightTruck for RouteMatrixTruckType
        /// </summary>
        public static readonly RouteMatrixTruckType StraightTruck = new RouteMatrixTruckType("StraightTruck");
        /// <summary>
        /// Constant Tractor for RouteMatrixTruckType
        /// </summary>
        public static readonly RouteMatrixTruckType Tractor = new RouteMatrixTruckType("Tractor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteMatrixTruckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteMatrixTruckType FindValue(string value)
        {
            return FindValue<RouteMatrixTruckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteMatrixTruckType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteMatrixZoneCategory.
    /// </summary>
    public class RouteMatrixZoneCategory : ConstantClass
    {

        /// <summary>
        /// Constant CongestionPricing for RouteMatrixZoneCategory
        /// </summary>
        public static readonly RouteMatrixZoneCategory CongestionPricing = new RouteMatrixZoneCategory("CongestionPricing");
        /// <summary>
        /// Constant Environmental for RouteMatrixZoneCategory
        /// </summary>
        public static readonly RouteMatrixZoneCategory Environmental = new RouteMatrixZoneCategory("Environmental");
        /// <summary>
        /// Constant Vignette for RouteMatrixZoneCategory
        /// </summary>
        public static readonly RouteMatrixZoneCategory Vignette = new RouteMatrixZoneCategory("Vignette");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteMatrixZoneCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteMatrixZoneCategory FindValue(string value)
        {
            return FindValue<RouteMatrixZoneCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteMatrixZoneCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteNoticeImpact.
    /// </summary>
    public class RouteNoticeImpact : ConstantClass
    {

        /// <summary>
        /// Constant High for RouteNoticeImpact
        /// </summary>
        public static readonly RouteNoticeImpact High = new RouteNoticeImpact("High");
        /// <summary>
        /// Constant Low for RouteNoticeImpact
        /// </summary>
        public static readonly RouteNoticeImpact Low = new RouteNoticeImpact("Low");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteNoticeImpact(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteNoticeImpact FindValue(string value)
        {
            return FindValue<RouteNoticeImpact>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteNoticeImpact(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutePedestrianNoticeCode.
    /// </summary>
    public class RoutePedestrianNoticeCode : ConstantClass
    {

        /// <summary>
        /// Constant AccuratePolylineUnavailable for RoutePedestrianNoticeCode
        /// </summary>
        public static readonly RoutePedestrianNoticeCode AccuratePolylineUnavailable = new RoutePedestrianNoticeCode("AccuratePolylineUnavailable");
        /// <summary>
        /// Constant Other for RoutePedestrianNoticeCode
        /// </summary>
        public static readonly RoutePedestrianNoticeCode Other = new RoutePedestrianNoticeCode("Other");
        /// <summary>
        /// Constant ViolatedAvoidDirtRoad for RoutePedestrianNoticeCode
        /// </summary>
        public static readonly RoutePedestrianNoticeCode ViolatedAvoidDirtRoad = new RoutePedestrianNoticeCode("ViolatedAvoidDirtRoad");
        /// <summary>
        /// Constant ViolatedAvoidTunnel for RoutePedestrianNoticeCode
        /// </summary>
        public static readonly RoutePedestrianNoticeCode ViolatedAvoidTunnel = new RoutePedestrianNoticeCode("ViolatedAvoidTunnel");
        /// <summary>
        /// Constant ViolatedPedestrianOption for RoutePedestrianNoticeCode
        /// </summary>
        public static readonly RoutePedestrianNoticeCode ViolatedPedestrianOption = new RoutePedestrianNoticeCode("ViolatedPedestrianOption");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutePedestrianNoticeCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutePedestrianNoticeCode FindValue(string value)
        {
            return FindValue<RoutePedestrianNoticeCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutePedestrianNoticeCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutePedestrianTravelStepType.
    /// </summary>
    public class RoutePedestrianTravelStepType : ConstantClass
    {

        /// <summary>
        /// Constant Arrive for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType Arrive = new RoutePedestrianTravelStepType("Arrive");
        /// <summary>
        /// Constant Continue for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType Continue = new RoutePedestrianTravelStepType("Continue");
        /// <summary>
        /// Constant Depart for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType Depart = new RoutePedestrianTravelStepType("Depart");
        /// <summary>
        /// Constant Exit for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType Exit = new RoutePedestrianTravelStepType("Exit");
        /// <summary>
        /// Constant Keep for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType Keep = new RoutePedestrianTravelStepType("Keep");
        /// <summary>
        /// Constant Ramp for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType Ramp = new RoutePedestrianTravelStepType("Ramp");
        /// <summary>
        /// Constant RoundaboutEnter for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType RoundaboutEnter = new RoutePedestrianTravelStepType("RoundaboutEnter");
        /// <summary>
        /// Constant RoundaboutExit for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType RoundaboutExit = new RoutePedestrianTravelStepType("RoundaboutExit");
        /// <summary>
        /// Constant RoundaboutPass for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType RoundaboutPass = new RoutePedestrianTravelStepType("RoundaboutPass");
        /// <summary>
        /// Constant Turn for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType Turn = new RoutePedestrianTravelStepType("Turn");
        /// <summary>
        /// Constant UTurn for RoutePedestrianTravelStepType
        /// </summary>
        public static readonly RoutePedestrianTravelStepType UTurn = new RoutePedestrianTravelStepType("UTurn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutePedestrianTravelStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutePedestrianTravelStepType FindValue(string value)
        {
            return FindValue<RoutePedestrianTravelStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutePedestrianTravelStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteResponseNoticeCode.
    /// </summary>
    public class RouteResponseNoticeCode : ConstantClass
    {

        /// <summary>
        /// Constant MainLanguageNotFound for RouteResponseNoticeCode
        /// </summary>
        public static readonly RouteResponseNoticeCode MainLanguageNotFound = new RouteResponseNoticeCode("MainLanguageNotFound");
        /// <summary>
        /// Constant Other for RouteResponseNoticeCode
        /// </summary>
        public static readonly RouteResponseNoticeCode Other = new RouteResponseNoticeCode("Other");
        /// <summary>
        /// Constant TravelTimeExceedsDriverWorkHours for RouteResponseNoticeCode
        /// </summary>
        public static readonly RouteResponseNoticeCode TravelTimeExceedsDriverWorkHours = new RouteResponseNoticeCode("TravelTimeExceedsDriverWorkHours");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteResponseNoticeCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteResponseNoticeCode FindValue(string value)
        {
            return FindValue<RouteResponseNoticeCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteResponseNoticeCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteRoadType.
    /// </summary>
    public class RouteRoadType : ConstantClass
    {

        /// <summary>
        /// Constant Highway for RouteRoadType
        /// </summary>
        public static readonly RouteRoadType Highway = new RouteRoadType("Highway");
        /// <summary>
        /// Constant Rural for RouteRoadType
        /// </summary>
        public static readonly RouteRoadType Rural = new RouteRoadType("Rural");
        /// <summary>
        /// Constant Urban for RouteRoadType
        /// </summary>
        public static readonly RouteRoadType Urban = new RouteRoadType("Urban");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteRoadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteRoadType FindValue(string value)
        {
            return FindValue<RouteRoadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteRoadType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSideOfStreet.
    /// </summary>
    public class RouteSideOfStreet : ConstantClass
    {

        /// <summary>
        /// Constant Left for RouteSideOfStreet
        /// </summary>
        public static readonly RouteSideOfStreet Left = new RouteSideOfStreet("Left");
        /// <summary>
        /// Constant Right for RouteSideOfStreet
        /// </summary>
        public static readonly RouteSideOfStreet Right = new RouteSideOfStreet("Right");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSideOfStreet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSideOfStreet FindValue(string value)
        {
            return FindValue<RouteSideOfStreet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSideOfStreet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanAdditionalFeature.
    /// </summary>
    public class RouteSpanAdditionalFeature : ConstantClass
    {

        /// <summary>
        /// Constant BestCaseDuration for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature BestCaseDuration = new RouteSpanAdditionalFeature("BestCaseDuration");
        /// <summary>
        /// Constant CarAccess for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature CarAccess = new RouteSpanAdditionalFeature("CarAccess");
        /// <summary>
        /// Constant Consumption for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Consumption = new RouteSpanAdditionalFeature("Consumption");
        /// <summary>
        /// Constant Country for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Country = new RouteSpanAdditionalFeature("Country");
        /// <summary>
        /// Constant Distance for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Distance = new RouteSpanAdditionalFeature("Distance");
        /// <summary>
        /// Constant Duration for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Duration = new RouteSpanAdditionalFeature("Duration");
        /// <summary>
        /// Constant DynamicSpeed for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature DynamicSpeed = new RouteSpanAdditionalFeature("DynamicSpeed");
        /// <summary>
        /// Constant FunctionalClassification for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature FunctionalClassification = new RouteSpanAdditionalFeature("FunctionalClassification");
        /// <summary>
        /// Constant Gates for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Gates = new RouteSpanAdditionalFeature("Gates");
        /// <summary>
        /// Constant Incidents for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Incidents = new RouteSpanAdditionalFeature("Incidents");
        /// <summary>
        /// Constant Names for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Names = new RouteSpanAdditionalFeature("Names");
        /// <summary>
        /// Constant Notices for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Notices = new RouteSpanAdditionalFeature("Notices");
        /// <summary>
        /// Constant PedestrianAccess for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature PedestrianAccess = new RouteSpanAdditionalFeature("PedestrianAccess");
        /// <summary>
        /// Constant RailwayCrossings for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature RailwayCrossings = new RouteSpanAdditionalFeature("RailwayCrossings");
        /// <summary>
        /// Constant Region for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Region = new RouteSpanAdditionalFeature("Region");
        /// <summary>
        /// Constant RoadAttributes for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature RoadAttributes = new RouteSpanAdditionalFeature("RoadAttributes");
        /// <summary>
        /// Constant RouteNumbers for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature RouteNumbers = new RouteSpanAdditionalFeature("RouteNumbers");
        /// <summary>
        /// Constant ScooterAccess for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature ScooterAccess = new RouteSpanAdditionalFeature("ScooterAccess");
        /// <summary>
        /// Constant SpeedLimit for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature SpeedLimit = new RouteSpanAdditionalFeature("SpeedLimit");
        /// <summary>
        /// Constant TollSystems for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature TollSystems = new RouteSpanAdditionalFeature("TollSystems");
        /// <summary>
        /// Constant TruckAccess for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature TruckAccess = new RouteSpanAdditionalFeature("TruckAccess");
        /// <summary>
        /// Constant TruckRoadTypes for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature TruckRoadTypes = new RouteSpanAdditionalFeature("TruckRoadTypes");
        /// <summary>
        /// Constant TypicalDuration for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature TypicalDuration = new RouteSpanAdditionalFeature("TypicalDuration");
        /// <summary>
        /// Constant Zones for RouteSpanAdditionalFeature
        /// </summary>
        public static readonly RouteSpanAdditionalFeature Zones = new RouteSpanAdditionalFeature("Zones");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanAdditionalFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanAdditionalFeature FindValue(string value)
        {
            return FindValue<RouteSpanAdditionalFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanAdditionalFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanCarAccessAttribute.
    /// </summary>
    public class RouteSpanCarAccessAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for RouteSpanCarAccessAttribute
        /// </summary>
        public static readonly RouteSpanCarAccessAttribute Allowed = new RouteSpanCarAccessAttribute("Allowed");
        /// <summary>
        /// Constant NoThroughTraffic for RouteSpanCarAccessAttribute
        /// </summary>
        public static readonly RouteSpanCarAccessAttribute NoThroughTraffic = new RouteSpanCarAccessAttribute("NoThroughTraffic");
        /// <summary>
        /// Constant TollRoad for RouteSpanCarAccessAttribute
        /// </summary>
        public static readonly RouteSpanCarAccessAttribute TollRoad = new RouteSpanCarAccessAttribute("TollRoad");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanCarAccessAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanCarAccessAttribute FindValue(string value)
        {
            return FindValue<RouteSpanCarAccessAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanCarAccessAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanGateAttribute.
    /// </summary>
    public class RouteSpanGateAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Emergency for RouteSpanGateAttribute
        /// </summary>
        public static readonly RouteSpanGateAttribute Emergency = new RouteSpanGateAttribute("Emergency");
        /// <summary>
        /// Constant KeyAccess for RouteSpanGateAttribute
        /// </summary>
        public static readonly RouteSpanGateAttribute KeyAccess = new RouteSpanGateAttribute("KeyAccess");
        /// <summary>
        /// Constant PermissionRequired for RouteSpanGateAttribute
        /// </summary>
        public static readonly RouteSpanGateAttribute PermissionRequired = new RouteSpanGateAttribute("PermissionRequired");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanGateAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanGateAttribute FindValue(string value)
        {
            return FindValue<RouteSpanGateAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanGateAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanPedestrianAccessAttribute.
    /// </summary>
    public class RouteSpanPedestrianAccessAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for RouteSpanPedestrianAccessAttribute
        /// </summary>
        public static readonly RouteSpanPedestrianAccessAttribute Allowed = new RouteSpanPedestrianAccessAttribute("Allowed");
        /// <summary>
        /// Constant Indoors for RouteSpanPedestrianAccessAttribute
        /// </summary>
        public static readonly RouteSpanPedestrianAccessAttribute Indoors = new RouteSpanPedestrianAccessAttribute("Indoors");
        /// <summary>
        /// Constant NoThroughTraffic for RouteSpanPedestrianAccessAttribute
        /// </summary>
        public static readonly RouteSpanPedestrianAccessAttribute NoThroughTraffic = new RouteSpanPedestrianAccessAttribute("NoThroughTraffic");
        /// <summary>
        /// Constant Park for RouteSpanPedestrianAccessAttribute
        /// </summary>
        public static readonly RouteSpanPedestrianAccessAttribute Park = new RouteSpanPedestrianAccessAttribute("Park");
        /// <summary>
        /// Constant Stairs for RouteSpanPedestrianAccessAttribute
        /// </summary>
        public static readonly RouteSpanPedestrianAccessAttribute Stairs = new RouteSpanPedestrianAccessAttribute("Stairs");
        /// <summary>
        /// Constant TollRoad for RouteSpanPedestrianAccessAttribute
        /// </summary>
        public static readonly RouteSpanPedestrianAccessAttribute TollRoad = new RouteSpanPedestrianAccessAttribute("TollRoad");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanPedestrianAccessAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanPedestrianAccessAttribute FindValue(string value)
        {
            return FindValue<RouteSpanPedestrianAccessAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanPedestrianAccessAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanRailwayCrossingAttribute.
    /// </summary>
    public class RouteSpanRailwayCrossingAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Protected for RouteSpanRailwayCrossingAttribute
        /// </summary>
        public static readonly RouteSpanRailwayCrossingAttribute Protected = new RouteSpanRailwayCrossingAttribute("Protected");
        /// <summary>
        /// Constant Unprotected for RouteSpanRailwayCrossingAttribute
        /// </summary>
        public static readonly RouteSpanRailwayCrossingAttribute Unprotected = new RouteSpanRailwayCrossingAttribute("Unprotected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanRailwayCrossingAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanRailwayCrossingAttribute FindValue(string value)
        {
            return FindValue<RouteSpanRailwayCrossingAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanRailwayCrossingAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanRoadAttribute.
    /// </summary>
    public class RouteSpanRoadAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Bridge for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute Bridge = new RouteSpanRoadAttribute("Bridge");
        /// <summary>
        /// Constant BuiltUpArea for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute BuiltUpArea = new RouteSpanRoadAttribute("BuiltUpArea");
        /// <summary>
        /// Constant ControlledAccessHighway for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute ControlledAccessHighway = new RouteSpanRoadAttribute("ControlledAccessHighway");
        /// <summary>
        /// Constant DirtRoad for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute DirtRoad = new RouteSpanRoadAttribute("DirtRoad");
        /// <summary>
        /// Constant DividedRoad for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute DividedRoad = new RouteSpanRoadAttribute("DividedRoad");
        /// <summary>
        /// Constant Motorway for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute Motorway = new RouteSpanRoadAttribute("Motorway");
        /// <summary>
        /// Constant PrivateRoad for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute PrivateRoad = new RouteSpanRoadAttribute("PrivateRoad");
        /// <summary>
        /// Constant Ramp for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute Ramp = new RouteSpanRoadAttribute("Ramp");
        /// <summary>
        /// Constant RightHandTraffic for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute RightHandTraffic = new RouteSpanRoadAttribute("RightHandTraffic");
        /// <summary>
        /// Constant Roundabout for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute Roundabout = new RouteSpanRoadAttribute("Roundabout");
        /// <summary>
        /// Constant Tunnel for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute Tunnel = new RouteSpanRoadAttribute("Tunnel");
        /// <summary>
        /// Constant UnderConstruction for RouteSpanRoadAttribute
        /// </summary>
        public static readonly RouteSpanRoadAttribute UnderConstruction = new RouteSpanRoadAttribute("UnderConstruction");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanRoadAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanRoadAttribute FindValue(string value)
        {
            return FindValue<RouteSpanRoadAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanRoadAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanScooterAccessAttribute.
    /// </summary>
    public class RouteSpanScooterAccessAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for RouteSpanScooterAccessAttribute
        /// </summary>
        public static readonly RouteSpanScooterAccessAttribute Allowed = new RouteSpanScooterAccessAttribute("Allowed");
        /// <summary>
        /// Constant NoThroughTraffic for RouteSpanScooterAccessAttribute
        /// </summary>
        public static readonly RouteSpanScooterAccessAttribute NoThroughTraffic = new RouteSpanScooterAccessAttribute("NoThroughTraffic");
        /// <summary>
        /// Constant TollRoad for RouteSpanScooterAccessAttribute
        /// </summary>
        public static readonly RouteSpanScooterAccessAttribute TollRoad = new RouteSpanScooterAccessAttribute("TollRoad");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanScooterAccessAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanScooterAccessAttribute FindValue(string value)
        {
            return FindValue<RouteSpanScooterAccessAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanScooterAccessAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSpanTruckAccessAttribute.
    /// </summary>
    public class RouteSpanTruckAccessAttribute : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for RouteSpanTruckAccessAttribute
        /// </summary>
        public static readonly RouteSpanTruckAccessAttribute Allowed = new RouteSpanTruckAccessAttribute("Allowed");
        /// <summary>
        /// Constant NoThroughTraffic for RouteSpanTruckAccessAttribute
        /// </summary>
        public static readonly RouteSpanTruckAccessAttribute NoThroughTraffic = new RouteSpanTruckAccessAttribute("NoThroughTraffic");
        /// <summary>
        /// Constant TollRoad for RouteSpanTruckAccessAttribute
        /// </summary>
        public static readonly RouteSpanTruckAccessAttribute TollRoad = new RouteSpanTruckAccessAttribute("TollRoad");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSpanTruckAccessAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSpanTruckAccessAttribute FindValue(string value)
        {
            return FindValue<RouteSpanTruckAccessAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSpanTruckAccessAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteSteeringDirection.
    /// </summary>
    public class RouteSteeringDirection : ConstantClass
    {

        /// <summary>
        /// Constant Left for RouteSteeringDirection
        /// </summary>
        public static readonly RouteSteeringDirection Left = new RouteSteeringDirection("Left");
        /// <summary>
        /// Constant Right for RouteSteeringDirection
        /// </summary>
        public static readonly RouteSteeringDirection Right = new RouteSteeringDirection("Right");
        /// <summary>
        /// Constant Straight for RouteSteeringDirection
        /// </summary>
        public static readonly RouteSteeringDirection Straight = new RouteSteeringDirection("Straight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteSteeringDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteSteeringDirection FindValue(string value)
        {
            return FindValue<RouteSteeringDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteSteeringDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTollPassValidityPeriodType.
    /// </summary>
    public class RouteTollPassValidityPeriodType : ConstantClass
    {

        /// <summary>
        /// Constant Annual for RouteTollPassValidityPeriodType
        /// </summary>
        public static readonly RouteTollPassValidityPeriodType Annual = new RouteTollPassValidityPeriodType("Annual");
        /// <summary>
        /// Constant Days for RouteTollPassValidityPeriodType
        /// </summary>
        public static readonly RouteTollPassValidityPeriodType Days = new RouteTollPassValidityPeriodType("Days");
        /// <summary>
        /// Constant ExtendedAnnual for RouteTollPassValidityPeriodType
        /// </summary>
        public static readonly RouteTollPassValidityPeriodType ExtendedAnnual = new RouteTollPassValidityPeriodType("ExtendedAnnual");
        /// <summary>
        /// Constant Minutes for RouteTollPassValidityPeriodType
        /// </summary>
        public static readonly RouteTollPassValidityPeriodType Minutes = new RouteTollPassValidityPeriodType("Minutes");
        /// <summary>
        /// Constant Months for RouteTollPassValidityPeriodType
        /// </summary>
        public static readonly RouteTollPassValidityPeriodType Months = new RouteTollPassValidityPeriodType("Months");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTollPassValidityPeriodType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTollPassValidityPeriodType FindValue(string value)
        {
            return FindValue<RouteTollPassValidityPeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTollPassValidityPeriodType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTollPaymentMethod.
    /// </summary>
    public class RouteTollPaymentMethod : ConstantClass
    {

        /// <summary>
        /// Constant BankCard for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod BankCard = new RouteTollPaymentMethod("BankCard");
        /// <summary>
        /// Constant Cash for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod Cash = new RouteTollPaymentMethod("Cash");
        /// <summary>
        /// Constant CashExact for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod CashExact = new RouteTollPaymentMethod("CashExact");
        /// <summary>
        /// Constant CreditCard for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod CreditCard = new RouteTollPaymentMethod("CreditCard");
        /// <summary>
        /// Constant PassSubscription for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod PassSubscription = new RouteTollPaymentMethod("PassSubscription");
        /// <summary>
        /// Constant Transponder for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod Transponder = new RouteTollPaymentMethod("Transponder");
        /// <summary>
        /// Constant TravelCard for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod TravelCard = new RouteTollPaymentMethod("TravelCard");
        /// <summary>
        /// Constant VideoToll for RouteTollPaymentMethod
        /// </summary>
        public static readonly RouteTollPaymentMethod VideoToll = new RouteTollPaymentMethod("VideoToll");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTollPaymentMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTollPaymentMethod FindValue(string value)
        {
            return FindValue<RouteTollPaymentMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTollPaymentMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTollVehicleCategory.
    /// </summary>
    public class RouteTollVehicleCategory : ConstantClass
    {

        /// <summary>
        /// Constant Minibus for RouteTollVehicleCategory
        /// </summary>
        public static readonly RouteTollVehicleCategory Minibus = new RouteTollVehicleCategory("Minibus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTollVehicleCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTollVehicleCategory FindValue(string value)
        {
            return FindValue<RouteTollVehicleCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTollVehicleCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTravelMode.
    /// </summary>
    public class RouteTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for RouteTravelMode
        /// </summary>
        public static readonly RouteTravelMode Car = new RouteTravelMode("Car");
        /// <summary>
        /// Constant Pedestrian for RouteTravelMode
        /// </summary>
        public static readonly RouteTravelMode Pedestrian = new RouteTravelMode("Pedestrian");
        /// <summary>
        /// Constant Scooter for RouteTravelMode
        /// </summary>
        public static readonly RouteTravelMode Scooter = new RouteTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for RouteTravelMode
        /// </summary>
        public static readonly RouteTravelMode Truck = new RouteTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTravelMode FindValue(string value)
        {
            return FindValue<RouteTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTravelStepType.
    /// </summary>
    public class RouteTravelStepType : ConstantClass
    {

        /// <summary>
        /// Constant Default for RouteTravelStepType
        /// </summary>
        public static readonly RouteTravelStepType Default = new RouteTravelStepType("Default");
        /// <summary>
        /// Constant TurnByTurn for RouteTravelStepType
        /// </summary>
        public static readonly RouteTravelStepType TurnByTurn = new RouteTravelStepType("TurnByTurn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTravelStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTravelStepType FindValue(string value)
        {
            return FindValue<RouteTravelStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTravelStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTruckType.
    /// </summary>
    public class RouteTruckType : ConstantClass
    {

        /// <summary>
        /// Constant LightTruck for RouteTruckType
        /// </summary>
        public static readonly RouteTruckType LightTruck = new RouteTruckType("LightTruck");
        /// <summary>
        /// Constant StraightTruck for RouteTruckType
        /// </summary>
        public static readonly RouteTruckType StraightTruck = new RouteTruckType("StraightTruck");
        /// <summary>
        /// Constant Tractor for RouteTruckType
        /// </summary>
        public static readonly RouteTruckType Tractor = new RouteTruckType("Tractor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTruckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTruckType FindValue(string value)
        {
            return FindValue<RouteTruckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTruckType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteTurnIntensity.
    /// </summary>
    public class RouteTurnIntensity : ConstantClass
    {

        /// <summary>
        /// Constant Sharp for RouteTurnIntensity
        /// </summary>
        public static readonly RouteTurnIntensity Sharp = new RouteTurnIntensity("Sharp");
        /// <summary>
        /// Constant Slight for RouteTurnIntensity
        /// </summary>
        public static readonly RouteTurnIntensity Slight = new RouteTurnIntensity("Slight");
        /// <summary>
        /// Constant Typical for RouteTurnIntensity
        /// </summary>
        public static readonly RouteTurnIntensity Typical = new RouteTurnIntensity("Typical");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTurnIntensity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTurnIntensity FindValue(string value)
        {
            return FindValue<RouteTurnIntensity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTurnIntensity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteVehicleIncidentSeverity.
    /// </summary>
    public class RouteVehicleIncidentSeverity : ConstantClass
    {

        /// <summary>
        /// Constant Critical for RouteVehicleIncidentSeverity
        /// </summary>
        public static readonly RouteVehicleIncidentSeverity Critical = new RouteVehicleIncidentSeverity("Critical");
        /// <summary>
        /// Constant High for RouteVehicleIncidentSeverity
        /// </summary>
        public static readonly RouteVehicleIncidentSeverity High = new RouteVehicleIncidentSeverity("High");
        /// <summary>
        /// Constant Low for RouteVehicleIncidentSeverity
        /// </summary>
        public static readonly RouteVehicleIncidentSeverity Low = new RouteVehicleIncidentSeverity("Low");
        /// <summary>
        /// Constant Medium for RouteVehicleIncidentSeverity
        /// </summary>
        public static readonly RouteVehicleIncidentSeverity Medium = new RouteVehicleIncidentSeverity("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteVehicleIncidentSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteVehicleIncidentSeverity FindValue(string value)
        {
            return FindValue<RouteVehicleIncidentSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteVehicleIncidentSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteVehicleIncidentType.
    /// </summary>
    public class RouteVehicleIncidentType : ConstantClass
    {

        /// <summary>
        /// Constant Accident for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType Accident = new RouteVehicleIncidentType("Accident");
        /// <summary>
        /// Constant Congestion for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType Congestion = new RouteVehicleIncidentType("Congestion");
        /// <summary>
        /// Constant Construction for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType Construction = new RouteVehicleIncidentType("Construction");
        /// <summary>
        /// Constant DisabledVehicle for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType DisabledVehicle = new RouteVehicleIncidentType("DisabledVehicle");
        /// <summary>
        /// Constant LaneRestriction for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType LaneRestriction = new RouteVehicleIncidentType("LaneRestriction");
        /// <summary>
        /// Constant MassTransit for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType MassTransit = new RouteVehicleIncidentType("MassTransit");
        /// <summary>
        /// Constant Other for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType Other = new RouteVehicleIncidentType("Other");
        /// <summary>
        /// Constant PlannedEvent for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType PlannedEvent = new RouteVehicleIncidentType("PlannedEvent");
        /// <summary>
        /// Constant RoadClosure for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType RoadClosure = new RouteVehicleIncidentType("RoadClosure");
        /// <summary>
        /// Constant RoadHazard for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType RoadHazard = new RouteVehicleIncidentType("RoadHazard");
        /// <summary>
        /// Constant Weather for RouteVehicleIncidentType
        /// </summary>
        public static readonly RouteVehicleIncidentType Weather = new RouteVehicleIncidentType("Weather");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteVehicleIncidentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteVehicleIncidentType FindValue(string value)
        {
            return FindValue<RouteVehicleIncidentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteVehicleIncidentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteVehicleNoticeCode.
    /// </summary>
    public class RouteVehicleNoticeCode : ConstantClass
    {

        /// <summary>
        /// Constant AccuratePolylineUnavailable for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode AccuratePolylineUnavailable = new RouteVehicleNoticeCode("AccuratePolylineUnavailable");
        /// <summary>
        /// Constant Other for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode Other = new RouteVehicleNoticeCode("Other");
        /// <summary>
        /// Constant PotentialViolatedAvoidTollRoadUsage for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode PotentialViolatedAvoidTollRoadUsage = new RouteVehicleNoticeCode("PotentialViolatedAvoidTollRoadUsage");
        /// <summary>
        /// Constant PotentialViolatedCarpoolUsage for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode PotentialViolatedCarpoolUsage = new RouteVehicleNoticeCode("PotentialViolatedCarpoolUsage");
        /// <summary>
        /// Constant PotentialViolatedTurnRestrictionUsage for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode PotentialViolatedTurnRestrictionUsage = new RouteVehicleNoticeCode("PotentialViolatedTurnRestrictionUsage");
        /// <summary>
        /// Constant PotentialViolatedVehicleRestrictionUsage for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode PotentialViolatedVehicleRestrictionUsage = new RouteVehicleNoticeCode("PotentialViolatedVehicleRestrictionUsage");
        /// <summary>
        /// Constant PotentialViolatedZoneRestrictionUsage for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode PotentialViolatedZoneRestrictionUsage = new RouteVehicleNoticeCode("PotentialViolatedZoneRestrictionUsage");
        /// <summary>
        /// Constant SeasonalClosure for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode SeasonalClosure = new RouteVehicleNoticeCode("SeasonalClosure");
        /// <summary>
        /// Constant TollsDataTemporarilyUnavailable for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode TollsDataTemporarilyUnavailable = new RouteVehicleNoticeCode("TollsDataTemporarilyUnavailable");
        /// <summary>
        /// Constant TollsDataUnavailable for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode TollsDataUnavailable = new RouteVehicleNoticeCode("TollsDataUnavailable");
        /// <summary>
        /// Constant TollTransponder for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode TollTransponder = new RouteVehicleNoticeCode("TollTransponder");
        /// <summary>
        /// Constant ViolatedAvoidControlledAccessHighway for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidControlledAccessHighway = new RouteVehicleNoticeCode("ViolatedAvoidControlledAccessHighway");
        /// <summary>
        /// Constant ViolatedAvoidDifficultTurns for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidDifficultTurns = new RouteVehicleNoticeCode("ViolatedAvoidDifficultTurns");
        /// <summary>
        /// Constant ViolatedAvoidDirtRoad for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidDirtRoad = new RouteVehicleNoticeCode("ViolatedAvoidDirtRoad");
        /// <summary>
        /// Constant ViolatedAvoidSeasonalClosure for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidSeasonalClosure = new RouteVehicleNoticeCode("ViolatedAvoidSeasonalClosure");
        /// <summary>
        /// Constant ViolatedAvoidTollRoad for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidTollRoad = new RouteVehicleNoticeCode("ViolatedAvoidTollRoad");
        /// <summary>
        /// Constant ViolatedAvoidTollTransponder for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidTollTransponder = new RouteVehicleNoticeCode("ViolatedAvoidTollTransponder");
        /// <summary>
        /// Constant ViolatedAvoidTruckRoadType for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidTruckRoadType = new RouteVehicleNoticeCode("ViolatedAvoidTruckRoadType");
        /// <summary>
        /// Constant ViolatedAvoidTunnel for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidTunnel = new RouteVehicleNoticeCode("ViolatedAvoidTunnel");
        /// <summary>
        /// Constant ViolatedAvoidUTurns for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedAvoidUTurns = new RouteVehicleNoticeCode("ViolatedAvoidUTurns");
        /// <summary>
        /// Constant ViolatedBlockedRoad for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedBlockedRoad = new RouteVehicleNoticeCode("ViolatedBlockedRoad");
        /// <summary>
        /// Constant ViolatedCarpool for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedCarpool = new RouteVehicleNoticeCode("ViolatedCarpool");
        /// <summary>
        /// Constant ViolatedEmergencyGate for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedEmergencyGate = new RouteVehicleNoticeCode("ViolatedEmergencyGate");
        /// <summary>
        /// Constant ViolatedStartDirection for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedStartDirection = new RouteVehicleNoticeCode("ViolatedStartDirection");
        /// <summary>
        /// Constant ViolatedTurnRestriction for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedTurnRestriction = new RouteVehicleNoticeCode("ViolatedTurnRestriction");
        /// <summary>
        /// Constant ViolatedVehicleRestriction for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedVehicleRestriction = new RouteVehicleNoticeCode("ViolatedVehicleRestriction");
        /// <summary>
        /// Constant ViolatedZoneRestriction for RouteVehicleNoticeCode
        /// </summary>
        public static readonly RouteVehicleNoticeCode ViolatedZoneRestriction = new RouteVehicleNoticeCode("ViolatedZoneRestriction");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteVehicleNoticeCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteVehicleNoticeCode FindValue(string value)
        {
            return FindValue<RouteVehicleNoticeCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteVehicleNoticeCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteVehicleTravelStepType.
    /// </summary>
    public class RouteVehicleTravelStepType : ConstantClass
    {

        /// <summary>
        /// Constant Arrive for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType Arrive = new RouteVehicleTravelStepType("Arrive");
        /// <summary>
        /// Constant Continue for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType Continue = new RouteVehicleTravelStepType("Continue");
        /// <summary>
        /// Constant ContinueHighway for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType ContinueHighway = new RouteVehicleTravelStepType("ContinueHighway");
        /// <summary>
        /// Constant Depart for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType Depart = new RouteVehicleTravelStepType("Depart");
        /// <summary>
        /// Constant EnterHighway for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType EnterHighway = new RouteVehicleTravelStepType("EnterHighway");
        /// <summary>
        /// Constant Exit for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType Exit = new RouteVehicleTravelStepType("Exit");
        /// <summary>
        /// Constant Keep for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType Keep = new RouteVehicleTravelStepType("Keep");
        /// <summary>
        /// Constant Ramp for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType Ramp = new RouteVehicleTravelStepType("Ramp");
        /// <summary>
        /// Constant RoundaboutEnter for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType RoundaboutEnter = new RouteVehicleTravelStepType("RoundaboutEnter");
        /// <summary>
        /// Constant RoundaboutExit for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType RoundaboutExit = new RouteVehicleTravelStepType("RoundaboutExit");
        /// <summary>
        /// Constant RoundaboutPass for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType RoundaboutPass = new RouteVehicleTravelStepType("RoundaboutPass");
        /// <summary>
        /// Constant Turn for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType Turn = new RouteVehicleTravelStepType("Turn");
        /// <summary>
        /// Constant UTurn for RouteVehicleTravelStepType
        /// </summary>
        public static readonly RouteVehicleTravelStepType UTurn = new RouteVehicleTravelStepType("UTurn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteVehicleTravelStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteVehicleTravelStepType FindValue(string value)
        {
            return FindValue<RouteVehicleTravelStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteVehicleTravelStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteWeightConstraintType.
    /// </summary>
    public class RouteWeightConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant Current for RouteWeightConstraintType
        /// </summary>
        public static readonly RouteWeightConstraintType Current = new RouteWeightConstraintType("Current");
        /// <summary>
        /// Constant Gross for RouteWeightConstraintType
        /// </summary>
        public static readonly RouteWeightConstraintType Gross = new RouteWeightConstraintType("Gross");
        /// <summary>
        /// Constant Unknown for RouteWeightConstraintType
        /// </summary>
        public static readonly RouteWeightConstraintType Unknown = new RouteWeightConstraintType("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteWeightConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteWeightConstraintType FindValue(string value)
        {
            return FindValue<RouteWeightConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteWeightConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteZoneCategory.
    /// </summary>
    public class RouteZoneCategory : ConstantClass
    {

        /// <summary>
        /// Constant CongestionPricing for RouteZoneCategory
        /// </summary>
        public static readonly RouteZoneCategory CongestionPricing = new RouteZoneCategory("CongestionPricing");
        /// <summary>
        /// Constant Environmental for RouteZoneCategory
        /// </summary>
        public static readonly RouteZoneCategory Environmental = new RouteZoneCategory("Environmental");
        /// <summary>
        /// Constant Vignette for RouteZoneCategory
        /// </summary>
        public static readonly RouteZoneCategory Vignette = new RouteZoneCategory("Vignette");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteZoneCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteZoneCategory FindValue(string value)
        {
            return FindValue<RouteZoneCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteZoneCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutingObjective.
    /// </summary>
    public class RoutingObjective : ConstantClass
    {

        /// <summary>
        /// Constant FastestRoute for RoutingObjective
        /// </summary>
        public static readonly RoutingObjective FastestRoute = new RoutingObjective("FastestRoute");
        /// <summary>
        /// Constant ShortestRoute for RoutingObjective
        /// </summary>
        public static readonly RoutingObjective ShortestRoute = new RoutingObjective("ShortestRoute");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingObjective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingObjective FindValue(string value)
        {
            return FindValue<RoutingObjective>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingObjective(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SideOfStreetMatchingStrategy.
    /// </summary>
    public class SideOfStreetMatchingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AnyStreet for SideOfStreetMatchingStrategy
        /// </summary>
        public static readonly SideOfStreetMatchingStrategy AnyStreet = new SideOfStreetMatchingStrategy("AnyStreet");
        /// <summary>
        /// Constant DividedStreetOnly for SideOfStreetMatchingStrategy
        /// </summary>
        public static readonly SideOfStreetMatchingStrategy DividedStreetOnly = new SideOfStreetMatchingStrategy("DividedStreetOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SideOfStreetMatchingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SideOfStreetMatchingStrategy FindValue(string value)
        {
            return FindValue<SideOfStreetMatchingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SideOfStreetMatchingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficUsage.
    /// </summary>
    public class TrafficUsage : ConstantClass
    {

        /// <summary>
        /// Constant IgnoreTrafficData for TrafficUsage
        /// </summary>
        public static readonly TrafficUsage IgnoreTrafficData = new TrafficUsage("IgnoreTrafficData");
        /// <summary>
        /// Constant UseTrafficData for TrafficUsage
        /// </summary>
        public static readonly TrafficUsage UseTrafficData = new TrafficUsage("UseTrafficData");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficUsage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficUsage FindValue(string value)
        {
            return FindValue<TrafficUsage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficUsage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("CannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");
        /// <summary>
        /// Constant Missing for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Missing = new ValidationExceptionReason("Missing");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("Other");
        /// <summary>
        /// Constant UnknownField for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownField = new ValidationExceptionReason("UnknownField");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("UnknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaypointOptimizationClusteringAlgorithm.
    /// </summary>
    public class WaypointOptimizationClusteringAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DrivingDistance for WaypointOptimizationClusteringAlgorithm
        /// </summary>
        public static readonly WaypointOptimizationClusteringAlgorithm DrivingDistance = new WaypointOptimizationClusteringAlgorithm("DrivingDistance");
        /// <summary>
        /// Constant TopologySegment for WaypointOptimizationClusteringAlgorithm
        /// </summary>
        public static readonly WaypointOptimizationClusteringAlgorithm TopologySegment = new WaypointOptimizationClusteringAlgorithm("TopologySegment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaypointOptimizationClusteringAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaypointOptimizationClusteringAlgorithm FindValue(string value)
        {
            return FindValue<WaypointOptimizationClusteringAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaypointOptimizationClusteringAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaypointOptimizationConstraint.
    /// </summary>
    public class WaypointOptimizationConstraint : ConstantClass
    {

        /// <summary>
        /// Constant AccessHours for WaypointOptimizationConstraint
        /// </summary>
        public static readonly WaypointOptimizationConstraint AccessHours = new WaypointOptimizationConstraint("AccessHours");
        /// <summary>
        /// Constant AppointmentTime for WaypointOptimizationConstraint
        /// </summary>
        public static readonly WaypointOptimizationConstraint AppointmentTime = new WaypointOptimizationConstraint("AppointmentTime");
        /// <summary>
        /// Constant Before for WaypointOptimizationConstraint
        /// </summary>
        public static readonly WaypointOptimizationConstraint Before = new WaypointOptimizationConstraint("Before");
        /// <summary>
        /// Constant Heading for WaypointOptimizationConstraint
        /// </summary>
        public static readonly WaypointOptimizationConstraint Heading = new WaypointOptimizationConstraint("Heading");
        /// <summary>
        /// Constant ServiceDuration for WaypointOptimizationConstraint
        /// </summary>
        public static readonly WaypointOptimizationConstraint ServiceDuration = new WaypointOptimizationConstraint("ServiceDuration");
        /// <summary>
        /// Constant SideOfStreet for WaypointOptimizationConstraint
        /// </summary>
        public static readonly WaypointOptimizationConstraint SideOfStreet = new WaypointOptimizationConstraint("SideOfStreet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaypointOptimizationConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaypointOptimizationConstraint FindValue(string value)
        {
            return FindValue<WaypointOptimizationConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaypointOptimizationConstraint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaypointOptimizationHazardousCargoType.
    /// </summary>
    public class WaypointOptimizationHazardousCargoType : ConstantClass
    {

        /// <summary>
        /// Constant Combustible for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Combustible = new WaypointOptimizationHazardousCargoType("Combustible");
        /// <summary>
        /// Constant Corrosive for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Corrosive = new WaypointOptimizationHazardousCargoType("Corrosive");
        /// <summary>
        /// Constant Explosive for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Explosive = new WaypointOptimizationHazardousCargoType("Explosive");
        /// <summary>
        /// Constant Flammable for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Flammable = new WaypointOptimizationHazardousCargoType("Flammable");
        /// <summary>
        /// Constant Gas for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Gas = new WaypointOptimizationHazardousCargoType("Gas");
        /// <summary>
        /// Constant HarmfulToWater for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType HarmfulToWater = new WaypointOptimizationHazardousCargoType("HarmfulToWater");
        /// <summary>
        /// Constant Organic for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Organic = new WaypointOptimizationHazardousCargoType("Organic");
        /// <summary>
        /// Constant Other for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Other = new WaypointOptimizationHazardousCargoType("Other");
        /// <summary>
        /// Constant Poison for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Poison = new WaypointOptimizationHazardousCargoType("Poison");
        /// <summary>
        /// Constant PoisonousInhalation for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType PoisonousInhalation = new WaypointOptimizationHazardousCargoType("PoisonousInhalation");
        /// <summary>
        /// Constant Radioactive for WaypointOptimizationHazardousCargoType
        /// </summary>
        public static readonly WaypointOptimizationHazardousCargoType Radioactive = new WaypointOptimizationHazardousCargoType("Radioactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaypointOptimizationHazardousCargoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaypointOptimizationHazardousCargoType FindValue(string value)
        {
            return FindValue<WaypointOptimizationHazardousCargoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaypointOptimizationHazardousCargoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaypointOptimizationSequencingObjective.
    /// </summary>
    public class WaypointOptimizationSequencingObjective : ConstantClass
    {

        /// <summary>
        /// Constant FastestRoute for WaypointOptimizationSequencingObjective
        /// </summary>
        public static readonly WaypointOptimizationSequencingObjective FastestRoute = new WaypointOptimizationSequencingObjective("FastestRoute");
        /// <summary>
        /// Constant ShortestRoute for WaypointOptimizationSequencingObjective
        /// </summary>
        public static readonly WaypointOptimizationSequencingObjective ShortestRoute = new WaypointOptimizationSequencingObjective("ShortestRoute");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaypointOptimizationSequencingObjective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaypointOptimizationSequencingObjective FindValue(string value)
        {
            return FindValue<WaypointOptimizationSequencingObjective>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaypointOptimizationSequencingObjective(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaypointOptimizationServiceTimeTreatment.
    /// </summary>
    public class WaypointOptimizationServiceTimeTreatment : ConstantClass
    {

        /// <summary>
        /// Constant Rest for WaypointOptimizationServiceTimeTreatment
        /// </summary>
        public static readonly WaypointOptimizationServiceTimeTreatment Rest = new WaypointOptimizationServiceTimeTreatment("Rest");
        /// <summary>
        /// Constant Work for WaypointOptimizationServiceTimeTreatment
        /// </summary>
        public static readonly WaypointOptimizationServiceTimeTreatment Work = new WaypointOptimizationServiceTimeTreatment("Work");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaypointOptimizationServiceTimeTreatment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaypointOptimizationServiceTimeTreatment FindValue(string value)
        {
            return FindValue<WaypointOptimizationServiceTimeTreatment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaypointOptimizationServiceTimeTreatment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaypointOptimizationTravelMode.
    /// </summary>
    public class WaypointOptimizationTravelMode : ConstantClass
    {

        /// <summary>
        /// Constant Car for WaypointOptimizationTravelMode
        /// </summary>
        public static readonly WaypointOptimizationTravelMode Car = new WaypointOptimizationTravelMode("Car");
        /// <summary>
        /// Constant Pedestrian for WaypointOptimizationTravelMode
        /// </summary>
        public static readonly WaypointOptimizationTravelMode Pedestrian = new WaypointOptimizationTravelMode("Pedestrian");
        /// <summary>
        /// Constant Scooter for WaypointOptimizationTravelMode
        /// </summary>
        public static readonly WaypointOptimizationTravelMode Scooter = new WaypointOptimizationTravelMode("Scooter");
        /// <summary>
        /// Constant Truck for WaypointOptimizationTravelMode
        /// </summary>
        public static readonly WaypointOptimizationTravelMode Truck = new WaypointOptimizationTravelMode("Truck");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaypointOptimizationTravelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaypointOptimizationTravelMode FindValue(string value)
        {
            return FindValue<WaypointOptimizationTravelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaypointOptimizationTravelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaypointOptimizationTruckType.
    /// </summary>
    public class WaypointOptimizationTruckType : ConstantClass
    {

        /// <summary>
        /// Constant StraightTruck for WaypointOptimizationTruckType
        /// </summary>
        public static readonly WaypointOptimizationTruckType StraightTruck = new WaypointOptimizationTruckType("StraightTruck");
        /// <summary>
        /// Constant Tractor for WaypointOptimizationTruckType
        /// </summary>
        public static readonly WaypointOptimizationTruckType Tractor = new WaypointOptimizationTruckType("Tractor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaypointOptimizationTruckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaypointOptimizationTruckType FindValue(string value)
        {
            return FindValue<WaypointOptimizationTruckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaypointOptimizationTruckType(string value)
        {
            return FindValue(value);
        }
    }

}