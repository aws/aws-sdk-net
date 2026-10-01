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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the GetObjectTypeAttributeStatistics operation. The
    /// GetObjectTypeAttributeValues API delivers statistical insights about attributes within
    /// a specific object type, but is exclusively available for domains with data store enabled.
    /// This API performs daily calculations to provide statistical information about your
    /// attribute values, helping you understand patterns and trends in your data. The statistical
    /// calculations are performed once per day, providing a consistent snapshot of your attribute
    /// data characteristics. <note> <para> You'll receive null values in two scenarios: </para>
    /// <para> During the first period after enabling data vault (unless a calculation cycle
    /// occurs, which happens once daily). </para> <para> For attributes that don't contain
    /// numeric values. </para> </note>
    /// </summary>
    public partial class GetObjectTypeAttributeStatisticsRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The attribute name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The unique name of the domain object type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ObjectTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ObjectTypeName property is set.
        /// </summary>
        internal bool IsSetObjectTypeName() => this.ObjectTypeName != null;
    }
}
