/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Attributes of the data specified by the customer. Use these to describe the data to
    /// be labeled.
    /// </summary>
    public partial class HumanReviewDataAttributes
    {
        private List<string> _contentClassifiers = new List<string>();

        /// <summary>
        /// Gets and sets the property ContentClassifiers. 
        /// <para>
        /// Declares that your content is free of personally identifiable information or adult
        /// content. Amazon SageMaker may restrict the Amazon Mechanical Turk workers that can
        /// view your task based on this information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public List<string> ContentClassifiers
        {
            get { return this._contentClassifiers; }
            set { this._contentClassifiers = value; }
        }

        // Check to see if ContentClassifiers property is set
        internal bool IsSetContentClassifiers()
        {
            return this._contentClassifiers != null && this._contentClassifiers.Count > 0; 
        }

    }
}