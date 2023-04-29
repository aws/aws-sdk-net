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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The label schema.
    /// </summary>
    public partial class LabelSchema
    {
        private Dictionary<string, List<string>> _labelMapper = new Dictionary<string, List<string>>();
        private UnlabeledEventsTreatment _unlabeledEventsTreatment;

        /// <summary>
        /// Gets and sets the property LabelMapper. 
        /// <para>
        /// The label mapper maps the Amazon Fraud Detector supported model classification labels
        /// (<code>FRAUD</code>, <code>LEGIT</code>) to the appropriate event type labels. For
        /// example, if "<code>FRAUD</code>" and "<code>LEGIT</code>" are Amazon Fraud Detector
        /// supported labels, this mapper could be: <code>{"FRAUD" =&gt; ["0"]</code>, <code>"LEGIT"
        /// =&gt; ["1"]}</code> or <code>{"FRAUD" =&gt; ["false"]</code>, <code>"LEGIT" =&gt;
        /// ["true"]}</code> or <code>{"FRAUD" =&gt; ["fraud", "abuse"]</code>, <code>"LEGIT"
        /// =&gt; ["legit", "safe"]}</code>. The value part of the mapper is a list, because you
        /// may have multiple label variants from your event type for a single Amazon Fraud Detector
        /// label. 
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> LabelMapper
        {
            get { return this._labelMapper; }
            set { this._labelMapper = value; }
        }

        // Check to see if LabelMapper property is set
        internal bool IsSetLabelMapper()
        {
            return this._labelMapper != null && this._labelMapper.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnlabeledEventsTreatment. 
        /// <para>
        /// The action to take for unlabeled events.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <code>IGNORE</code> if you want the unlabeled events to be ignored. This is recommended
        /// when the majority of the events in the dataset are labeled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>FRAUD</code> if you want to categorize all unlabeled events as “Fraud”.
        /// This is recommended when most of the events in your dataset are fraudulent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>LEGIT</code> f you want to categorize all unlabeled events as “Legit”. This
        /// is recommended when most of the events in your dataset are legitimate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>AUTO</code> if you want Amazon Fraud Detector to decide how to use the unlabeled
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