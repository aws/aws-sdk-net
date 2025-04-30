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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Specify an instance family to use as the baseline reference for CPU performance. All
    /// instance types that match your specified attributes will be compared against the CPU
    /// performance of the referenced instance family, regardless of CPU manufacturer or architecture.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, only one instance family can be specified in the list.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PerformanceFactorReferenceRequest
    {
        private string _instanceFamily;

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family to use as a baseline reference.
        /// </para>
        ///  <note> 
        /// <para>
        /// Ensure that you specify the correct value for the instance family. The instance family
        /// is everything before the period (<c>.</c>) in the instance type name. For example,
        /// in the instance type <c>c6i.large</c>, the instance family is <c>c6i</c>, not <c>c6</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/instance-type-names.html">Amazon
        /// EC2 instance type naming conventions</a> in <i>Amazon EC2 Instance Types</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following instance families are <i>not supported</i> for performance protection:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>c1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>g3</c> | <c>g3s</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hpc7g</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>m1</c> | <c>m2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mac1</c> | <c>mac2</c> | <c>mac2-m1ultra</c> | <c>mac2-m2</c> | <c>mac2-m2pro</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>p3dn</c> | <c>p4d</c> | <c>p5</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>t1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>u-12tb1</c> | <c>u-18tb1</c> | <c>u-24tb1</c> | <c>u-3tb1</c> | <c>u-6tb1</c>
        /// | <c>u-9tb1</c> | <c>u7i-12tb</c> | <c>u7in-16tb</c> | <c>u7in-24tb</c> | <c>u7in-32tb</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you enable performance protection by specifying a supported instance family, the
        /// returned instance types will exclude the above unsupported instance families.
        /// </para>
        ///  
        /// <para>
        /// If you specify an unsupported instance family as a value for baseline performance,
        /// the API returns an empty response for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetInstanceTypesFromInstanceRequirements">GetInstanceTypesFromInstanceRequirements</a>
        /// and an exception for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>,
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotFleet">RequestSpotFleet</a>,
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyFleet">ModifyFleet</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifySpotFleetRequest">ModifySpotFleetRequest</a>.
        /// </para>
        /// </summary>
        public string InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

    }
}