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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRetrainingScheduler operation. Updates a
    /// retraining scheduler.
    /// </summary>
    public partial class UpdateRetrainingSchedulerRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property LookbackWindow. 
        /// <para>
        /// The number of past days of data that will be used for retraining.
        /// </para>
        /// </summary>
        public string LookbackWindow { get; set; }

        /// <summary>
        /// Checks to see if the LookbackWindow property is set.
        /// </summary>
        internal bool IsSetLookbackWindow() => this.LookbackWindow != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model whose retraining scheduler you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property PromoteMode. 
        /// <para>
        /// Indicates how the service will use new models. In <c>MANAGED</c> mode, new models
        /// will automatically be used for inference if they have better performance than the
        /// current model. In <c>MANUAL</c> mode, the new models will not be used <a href="https://docs.aws.amazon.com/lookout-for-equipment/latest/ug/versioning-model.html#model-activation">until
        /// they are manually activated</a>.
        /// </para>
        /// </summary>
        public ModelPromoteMode PromoteMode { get; set; }

        /// <summary>
        /// Checks to see if the PromoteMode property is set.
        /// </summary>
        internal bool IsSetPromoteMode() => this.PromoteMode != null;

        /// <summary>
        /// Gets and sets the property RetrainingFrequency. 
        /// <para>
        /// This parameter uses the <a href="https://en.wikipedia.org/wiki/ISO_8601#Durations">ISO
        /// 8601</a> standard to set the frequency at which you want retraining to occur in terms
        /// of Years, Months, and/or Days (note: other parameters like Time are not currently
        /// supported). The minimum value is 30 days (P30D) and the maximum value is 1 year (P1Y).
        /// For example, the following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// P3M15D – Every 3 months and 15 days
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// P2M – Every 2 months
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// P150D – Every 150 days
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string RetrainingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the RetrainingFrequency property is set.
        /// </summary>
        internal bool IsSetRetrainingFrequency() => this.RetrainingFrequency != null;

        /// <summary>
        /// Gets and sets the property RetrainingStartDate. 
        /// <para>
        /// The start date for the retraining scheduler. Lookout for Equipment truncates the time
        /// you provide to the nearest UTC day.
        /// </para>
        /// </summary>
        public DateTime? RetrainingStartDate { get; set; }

        /// <summary>
        /// Checks to see if the RetrainingStartDate property is set.
        /// </summary>
        internal bool IsSetRetrainingStartDate() => this.RetrainingStartDate.HasValue;
    }
}
