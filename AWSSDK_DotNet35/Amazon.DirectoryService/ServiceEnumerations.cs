/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DirectoryService
{

    /// <summary>
    /// Constants used for properties of type DirectorySize.
    /// </summary>
    public class DirectorySize : ConstantClass
    {

        /// <summary>
        /// Constant Large for DirectorySize
        /// </summary>
        public static readonly DirectorySize Large = new DirectorySize("Large");
        /// <summary>
        /// Constant Small for DirectorySize
        /// </summary>
        public static readonly DirectorySize Small = new DirectorySize("Small");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DirectorySize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectorySize FindValue(string value)
        {
            return FindValue<DirectorySize>(value);
        }

        public static implicit operator DirectorySize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryStage.
    /// </summary>
    public class DirectoryStage : ConstantClass
    {

        /// <summary>
        /// Constant Active for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Active = new DirectoryStage("Active");
        /// <summary>
        /// Constant Created for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Created = new DirectoryStage("Created");
        /// <summary>
        /// Constant Creating for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Creating = new DirectoryStage("Creating");
        /// <summary>
        /// Constant Deleted for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Deleted = new DirectoryStage("Deleted");
        /// <summary>
        /// Constant Deleting for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Deleting = new DirectoryStage("Deleting");
        /// <summary>
        /// Constant Failed for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Failed = new DirectoryStage("Failed");
        /// <summary>
        /// Constant Impaired for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Impaired = new DirectoryStage("Impaired");
        /// <summary>
        /// Constant Inoperable for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Inoperable = new DirectoryStage("Inoperable");
        /// <summary>
        /// Constant Requested for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Requested = new DirectoryStage("Requested");
        /// <summary>
        /// Constant RestoreFailed for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage RestoreFailed = new DirectoryStage("RestoreFailed");
        /// <summary>
        /// Constant Restoring for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Restoring = new DirectoryStage("Restoring");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DirectoryStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryStage FindValue(string value)
        {
            return FindValue<DirectoryStage>(value);
        }

        public static implicit operator DirectoryStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryType.
    /// </summary>
    public class DirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant ADConnector for DirectoryType
        /// </summary>
        public static readonly DirectoryType ADConnector = new DirectoryType("ADConnector");
        /// <summary>
        /// Constant MicrosoftAD for DirectoryType
        /// </summary>
        public static readonly DirectoryType MicrosoftAD = new DirectoryType("MicrosoftAD");
        /// <summary>
        /// Constant SimpleAD for DirectoryType
        /// </summary>
        public static readonly DirectoryType SimpleAD = new DirectoryType("SimpleAD");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryType FindValue(string value)
        {
            return FindValue<DirectoryType>(value);
        }

        public static implicit operator DirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RadiusAuthenticationProtocol.
    /// </summary>
    public class RadiusAuthenticationProtocol : ConstantClass
    {

        /// <summary>
        /// Constant CHAP for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol CHAP = new RadiusAuthenticationProtocol("CHAP");
        /// <summary>
        /// Constant MSCHAPv1 for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol MSCHAPv1 = new RadiusAuthenticationProtocol("MS-CHAPv1");
        /// <summary>
        /// Constant MSCHAPv2 for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol MSCHAPv2 = new RadiusAuthenticationProtocol("MS-CHAPv2");
        /// <summary>
        /// Constant PAP for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol PAP = new RadiusAuthenticationProtocol("PAP");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RadiusAuthenticationProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RadiusAuthenticationProtocol FindValue(string value)
        {
            return FindValue<RadiusAuthenticationProtocol>(value);
        }

        public static implicit operator RadiusAuthenticationProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RadiusStatus.
    /// </summary>
    public class RadiusStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for RadiusStatus
        /// </summary>
        public static readonly RadiusStatus Completed = new RadiusStatus("Completed");
        /// <summary>
        /// Constant Creating for RadiusStatus
        /// </summary>
        public static readonly RadiusStatus Creating = new RadiusStatus("Creating");
        /// <summary>
        /// Constant Failed for RadiusStatus
        /// </summary>
        public static readonly RadiusStatus Failed = new RadiusStatus("Failed");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RadiusStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RadiusStatus FindValue(string value)
        {
            return FindValue<RadiusStatus>(value);
        }

        public static implicit operator RadiusStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotStatus.
    /// </summary>
    public class SnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus Completed = new SnapshotStatus("Completed");
        /// <summary>
        /// Constant Creating for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus Creating = new SnapshotStatus("Creating");
        /// <summary>
        /// Constant Failed for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus Failed = new SnapshotStatus("Failed");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotStatus FindValue(string value)
        {
            return FindValue<SnapshotStatus>(value);
        }

        public static implicit operator SnapshotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotType.
    /// </summary>
    public class SnapshotType : ConstantClass
    {

        /// <summary>
        /// Constant Auto for SnapshotType
        /// </summary>
        public static readonly SnapshotType Auto = new SnapshotType("Auto");
        /// <summary>
        /// Constant Manual for SnapshotType
        /// </summary>
        public static readonly SnapshotType Manual = new SnapshotType("Manual");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SnapshotType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotType FindValue(string value)
        {
            return FindValue<SnapshotType>(value);
        }

        public static implicit operator SnapshotType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TopicStatus.
    /// </summary>
    public class TopicStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleted for TopicStatus
        /// </summary>
        public static readonly TopicStatus Deleted = new TopicStatus("Deleted");
        /// <summary>
        /// Constant Failed for TopicStatus
        /// </summary>
        public static readonly TopicStatus Failed = new TopicStatus("Failed");
        /// <summary>
        /// Constant Registered for TopicStatus
        /// </summary>
        public static readonly TopicStatus Registered = new TopicStatus("Registered");
        /// <summary>
        /// Constant TopicNotFound for TopicStatus
        /// </summary>
        public static readonly TopicStatus TopicNotFound = new TopicStatus("Topic not found");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TopicStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TopicStatus FindValue(string value)
        {
            return FindValue<TopicStatus>(value);
        }

        public static implicit operator TopicStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustDirection.
    /// </summary>
    public class TrustDirection : ConstantClass
    {

        /// <summary>
        /// Constant OneWayIncoming for TrustDirection
        /// </summary>
        public static readonly TrustDirection OneWayIncoming = new TrustDirection("One-Way: Incoming");
        /// <summary>
        /// Constant OneWayOutgoing for TrustDirection
        /// </summary>
        public static readonly TrustDirection OneWayOutgoing = new TrustDirection("One-Way: Outgoing");
        /// <summary>
        /// Constant TwoWay for TrustDirection
        /// </summary>
        public static readonly TrustDirection TwoWay = new TrustDirection("Two-Way");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TrustDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustDirection FindValue(string value)
        {
            return FindValue<TrustDirection>(value);
        }

        public static implicit operator TrustDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustState.
    /// </summary>
    public class TrustState : ConstantClass
    {

        /// <summary>
        /// Constant Created for TrustState
        /// </summary>
        public static readonly TrustState Created = new TrustState("Created");
        /// <summary>
        /// Constant Creating for TrustState
        /// </summary>
        public static readonly TrustState Creating = new TrustState("Creating");
        /// <summary>
        /// Constant Deleted for TrustState
        /// </summary>
        public static readonly TrustState Deleted = new TrustState("Deleted");
        /// <summary>
        /// Constant Deleting for TrustState
        /// </summary>
        public static readonly TrustState Deleting = new TrustState("Deleting");
        /// <summary>
        /// Constant Failed for TrustState
        /// </summary>
        public static readonly TrustState Failed = new TrustState("Failed");
        /// <summary>
        /// Constant Verified for TrustState
        /// </summary>
        public static readonly TrustState Verified = new TrustState("Verified");
        /// <summary>
        /// Constant VerifyFailed for TrustState
        /// </summary>
        public static readonly TrustState VerifyFailed = new TrustState("VerifyFailed");
        /// <summary>
        /// Constant Verifying for TrustState
        /// </summary>
        public static readonly TrustState Verifying = new TrustState("Verifying");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TrustState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustState FindValue(string value)
        {
            return FindValue<TrustState>(value);
        }

        public static implicit operator TrustState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustType.
    /// </summary>
    public class TrustType : ConstantClass
    {

        /// <summary>
        /// Constant Forest for TrustType
        /// </summary>
        public static readonly TrustType Forest = new TrustType("Forest");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TrustType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustType FindValue(string value)
        {
            return FindValue<TrustType>(value);
        }

        public static implicit operator TrustType(string value)
        {
            return FindValue(value);
        }
    }

}