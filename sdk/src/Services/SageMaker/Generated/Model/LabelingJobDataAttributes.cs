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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Attributes of the data specified by the customer. Use these to describe the data to
    /// be labeled.
    /// </summary>
    public partial class LabelingJobDataAttributes
    {
        private List<string> _contentClassifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ContentClassifiers. 
        /// <para>
        /// Declares that your content is free of personally identifiable information or adult
        /// content. SageMaker may restrict the Amazon Mechanical Turk workers that can view your
        /// task based on this information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public List<string> ContentClassifiers
        {
            get { return this._contentClassifiers; }
            set { this._contentClassifiers = value; }
        }

        // Check to see if ContentClassifiers property is set
        internal bool IsSetContentClassifiers()
        {
            return this._contentClassifiers != null && (this._contentClassifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}