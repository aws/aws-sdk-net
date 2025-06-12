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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// The custom terminology applied to the input text by Amazon Translate for the translated
    /// text response. This is optional in the response and will only be present if you specified
    /// terminology input in the request. Currently, only one terminology can be applied per
    /// TranslateText request.
    /// </summary>
    public partial class AppliedTerminology
    {
        private string _name;
        private List<Term> _terms = AWSConfigs.InitializeCollections ? new List<Term>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom terminology applied to the input text by Amazon Translate for
        /// the translated text response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property Terms. 
        /// <para>
        /// The specific terms of the custom terminology applied to the input text by Amazon Translate
        /// for the translated text response. A maximum of 250 terms will be returned, and the
        /// specific terms applied will be the first 250 terms in the source text. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Term> Terms
        {
            get { return this._terms; }
            set { this._terms = value; }
        }

        // Check to see if Terms property is set
        internal bool IsSetTerms()
        {
            return this._terms != null && (this._terms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}