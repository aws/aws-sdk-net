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
    /// Represents an entry in a batch operation to create bill scenario usage modifications.
    /// </summary>
    public partial class BatchCreateBillScenarioUsageModificationEntry
    {
        /// <summary>
        /// Gets and sets the property Amounts. 
        /// <para>
        ///  The amount of usage you want to create for the service use you are modeling. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageAmount> Amounts { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageAmount>() : null;

        /// <summary>
        /// Checks to see if the Amounts property is set.
        /// </summary>
        internal bool IsSetAmounts() => this.Amounts != null && (this.Amounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The Availability Zone that this usage line uses. 
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
        ///  An optional group identifier for the usage modification. 
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
        /// Gets and sets the property Key. 
        /// <para>
        ///  A unique identifier for this entry in the batch operation. This can be any valid
        /// string. This key is useful to identify errors associated with any usage entry as any
        /// error is returned with this key. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The specific operation associated with this usage modification. Describes the specific
        /// Amazon Web Services operation that this usage line models. For example, <c>RunInstances</c>
        /// indicates the operation of an Amazon EC2 instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code for this usage modification. This identifies
        /// the specific Amazon Web Services service to the customer as a unique short abbreviation.
        /// For example, <c>AmazonEC2</c> and <c>AWSKMS</c>. 
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
        ///  The Amazon Web Services account ID to which this usage will be applied to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string UsageAccountId { get; set; }

        /// <summary>
        /// Checks to see if the UsageAccountId property is set.
        /// </summary>
        internal bool IsSetUsageAccountId() => this.UsageAccountId != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  Describes the usage details of the usage line item. 
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
