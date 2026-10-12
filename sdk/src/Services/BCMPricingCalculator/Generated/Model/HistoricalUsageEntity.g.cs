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
    /// Represents historical usage data for a specific entity.
    /// </summary>
    public partial class HistoricalUsageEntity
    {
        /// <summary>
        /// Gets and sets the property BillInterval. 
        /// <para>
        ///  The time interval for the historical usage data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillInterval BillInterval { get; set; }

        /// <summary>
        /// Checks to see if the BillInterval property is set.
        /// </summary>
        internal bool IsSetBillInterval() => this.BillInterval != null;

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        ///  An optional filter expression to apply to the historical usage data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Expression FilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the FilterExpression property is set.
        /// </summary>
        internal bool IsSetFilterExpression() => this.FilterExpression != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location associated with the usage. 
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
        ///  The specific operation associated with the usage. 
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
        ///  The Amazon Web Services service code associated with the usage. 
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
        ///  The Amazon Web Services account ID associated with the usage. 
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
        ///  The type of usage. 
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
