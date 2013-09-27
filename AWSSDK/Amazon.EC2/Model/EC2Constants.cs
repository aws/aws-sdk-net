/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Constants for the possible virtualization type.
    /// <see href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/index.html?ApiReference-query-RunInstances.html"/>
    /// </summary>
    public sealed class VirtualizationType
    {
        /// <summary>
        /// HVM (Hardware Virtual Machine) based virtualization is a type of full virtualization enabled through native
        /// hardware platform support for virtualization.
        /// </summary>
        public const string Hvm = "hvm";

        /// <summary>
        /// PVM (Para-Virtual Machine) based virtualization does not have direct access to the hardware.
        /// </summary>
        public const string ParaVirtual = "paravirtual";

        private VirtualizationType()
        { 
        }
    }

    /// <summary>
    /// Constants for the strategy of a placement group.
    /// <see href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/index.html?ApiReference_query_CreatePlacementGroup.html"/>
    /// </summary>
    public sealed class PlacementStrategy
    {
        public const string Cluster = "cluster";

        private PlacementStrategy()
        { 
        }
    }

    /// <summary>
    /// The instance types possible by EC2.
    /// <see href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/index.html?ApiReference-query-RunInstances.html"/>
    /// </summary>
    public sealed class InstanceType
    {
        // Standard instances
        public const string M1Small = "m1.small";
        public const string M1Medium = "m1.medium";
        public const string M1Large = "m1.large";
        public const string M1Xlarge = "m1.xlarge";
        public const string M3Xlarge = "m3.xlarge";
        public const string M32xlarge = "m3.2xlarge";

        // Micro instances
        public const string T1micro = "t1.micro";

        // High-memory instances
        public const string M2Xlarge = "m2.xlarge";
        public const string M22xlarge = "m2.2xlarge";
        public const string M24xlarge = "m2.4xlarge";

        // High-CPU instances
        public const string C1Medium = "c1.medium";
        public const string C1Xlarge = "c1.xlarge";

        // Cluster compute instances
        public const string Cc14xlarge = "cc1.4xlarge";
        public const string Cc28xlarge = "cc2.8xlarge";

        // Cluster GPU instances
        public const string Cg14xlarge = "cg1.4xlarge";

        // High IO instances
        public const string Hi14xlarge = "hi1.4xlarge";

        private InstanceType()
        {
        }
    }
}
