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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents a usage modification item in a bill scenario.
    /// </summary>
    public partial class BillScenarioUsageModificationItem
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The availability zone associated with this usage modification, if applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        ///  The group identifier for the usage modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property HistoricalUsage. 
        /// <para>
        ///  Historical usage data associated with this modification, if available. 
        /// </para>
        /// </summary>
        public HistoricalUsageEntity HistoricalUsage { get; set; }

        /// <summary>
        /// Checks to see if the HistoricalUsage property is set.
        /// </summary>
        internal bool IsSetHistoricalUsage() => this.HistoricalUsage != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of the usage modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location associated with this usage modification. 
        /// </para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The specific operation associated with this usage modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Quantities. 
        /// <para>
        ///  The modified usage quantities. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageQuantity> Quantities { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageQuantity>() : null;

        /// <summary>
        /// Checks to see if the Quantities property is set.
        /// </summary>
        internal bool IsSetQuantities() => this.Quantities != null && (this.Quantities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code for this usage modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with this usage modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string UsageAccountId { get; set; }

        /// <summary>
        /// Checks to see if the UsageAccountId property is set.
        /// </summary>
        internal bool IsSetUsageAccountId() => this.UsageAccountId != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  The type of usage being modified. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
