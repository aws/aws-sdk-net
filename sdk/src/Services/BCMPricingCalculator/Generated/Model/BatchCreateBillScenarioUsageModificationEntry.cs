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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
        private List<UsageAmount> _amounts = AWSConfigs.InitializeCollections ? new List<UsageAmount>() : null;
        private string _availabilityZone;
        private string _group;
        private HistoricalUsageEntity _historicalUsage;
        private string _key;
        private string _operation;
        private string _serviceCode;
        private string _usageAccountId;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property Amounts. 
        /// <para>
        ///  The amount of usage you want to create for the service use you are modeling. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageAmount> Amounts
        {
            get { return this._amounts; }
            set { this._amounts = value; }
        }

        // Check to see if Amounts property is set
        internal bool IsSetAmounts()
        {
            return this._amounts != null && (this._amounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The Availability Zone that this usage line uses. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        ///  An optional group identifier for the usage modification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property HistoricalUsage. 
        /// <para>
        ///  Historical usage data associated with this modification, if available. 
        /// </para>
        /// </summary>
        public HistoricalUsageEntity HistoricalUsage
        {
            get { return this._historicalUsage; }
            set { this._historicalUsage = value; }
        }

        // Check to see if HistoricalUsage property is set
        internal bool IsSetHistoricalUsage()
        {
            return this._historicalUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  A unique identifier for this entry in the batch operation. This can be any valid
        /// string. This key is useful to identify errors associated with any usage entry as any
        /// error is returned with this key. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The specific operation associated with this usage modification. Describes the specific
        /// Amazon Web Services operation that this usage line models. For example, <c>RunInstances</c>
        /// indicates the operation of an Amazon EC2 instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code for this usage modification. This identifies
        /// the specific Amazon Web Services service to the customer as a unique short abbreviation.
        /// For example, <c>AmazonEC2</c> and <c>AWSKMS</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID to which this usage will be applied to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string UsageAccountId
        {
            get { return this._usageAccountId; }
            set { this._usageAccountId = value; }
        }

        // Check to see if UsageAccountId property is set
        internal bool IsSetUsageAccountId()
        {
            return this._usageAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  Describes the usage details of the usage line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

    }
}