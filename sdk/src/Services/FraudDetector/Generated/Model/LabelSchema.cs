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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The label schema.
    /// </summary>
    public partial class LabelSchema
    {
        private Dictionary<string, List<string>> _labelMapper = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private UnlabeledEventsTreatment _unlabeledEventsTreatment;

        /// <summary>
        /// Gets and sets the property LabelMapper. 
        /// <para>
        /// The label mapper maps the Amazon Fraud Detector supported model classification labels
        /// (<c>FRAUD</c>, <c>LEGIT</c>) to the appropriate event type labels. For example, if
        /// "<c>FRAUD</c>" and "<c>LEGIT</c>" are Amazon Fraud Detector supported labels, this
        /// mapper could be: <c>{"FRAUD" =&gt; ["0"]</c>, <c>"LEGIT" =&gt; ["1"]}</c> or <c>{"FRAUD"
        /// =&gt; ["false"]</c>, <c>"LEGIT" =&gt; ["true"]}</c> or <c>{"FRAUD" =&gt; ["fraud",
        /// "abuse"]</c>, <c>"LEGIT" =&gt; ["legit", "safe"]}</c>. The value part of the mapper
        /// is a list, because you may have multiple label variants from your event type for a
        /// single Amazon Fraud Detector label. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> LabelMapper
        {
            get { return this._labelMapper; }
            set { this._labelMapper = value; }
        }

        // Check to see if LabelMapper property is set
        internal bool IsSetLabelMapper()
        {
            return this._labelMapper != null && (this._labelMapper.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnlabeledEventsTreatment. 
        /// <para>
        /// The action to take for unlabeled events.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>IGNORE</c> if you want the unlabeled events to be ignored. This is recommended
        /// when the majority of the events in the dataset are labeled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>FRAUD</c> if you want to categorize all unlabeled events as “Fraud”. This is
        /// recommended when most of the events in your dataset are fraudulent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>LEGIT</c> if you want to categorize all unlabeled events as “Legit”. This is
        /// recommended when most of the events in your dataset are legitimate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>AUTO</c> if you want Amazon Fraud Detector to decide how to use the unlabeled
        /// data. This is recommended when there is significant unlabeled events in the dataset.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, Amazon Fraud Detector ignores the unlabeled data.
        /// </para>
        /// </summary>
        public UnlabeledEventsTreatment UnlabeledEventsTreatment
        {
            get { return this._unlabeledEventsTreatment; }
            set { this._unlabeledEventsTreatment = value; }
        }

        // Check to see if UnlabeledEventsTreatment property is set
        internal bool IsSetUnlabeledEventsTreatment()
        {
            return this._unlabeledEventsTreatment != null;
        }

    }
}