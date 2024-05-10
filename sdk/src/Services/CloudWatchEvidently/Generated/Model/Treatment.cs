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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// A structure that defines one treatment in an experiment. A treatment is a variation
    /// of the feature that you are including in the experiment.
    /// </summary>
    public partial class Treatment
    {
        private string _description;
        private Dictionary<string, string> _featureVariations = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureVariations. 
        /// <para>
        /// The feature variation used for this treatment. This is a key-value pair. The key is
        /// the feature name, and the value is the variation name.
        /// </para>
        /// </summary>
        public Dictionary<string, string> FeatureVariations
        {
            get { return this._featureVariations; }
            set { this._featureVariations = value; }
        }

        // Check to see if FeatureVariations property is set
        internal bool IsSetFeatureVariations()
        {
            return this._featureVariations != null && (this._featureVariations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}