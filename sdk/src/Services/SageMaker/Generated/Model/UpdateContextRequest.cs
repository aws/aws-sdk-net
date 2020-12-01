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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContext operation.
    /// Updates a context.
    /// </summary>
    public partial class UpdateContextRequest : AmazonSageMakerRequest
    {
        private string _contextName;
        private string _description;
        private Dictionary<string, string> _properties = new Dictionary<string, string>();
        private List<string> _propertiesToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property ContextName. 
        /// <para>
        /// The name of the context to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string ContextName
        {
            get { return this._contextName; }
            set { this._contextName = value; }
        }

        // Check to see if ContextName property is set
        internal bool IsSetContextName()
        {
            return this._contextName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the context.
        /// </para>
        /// </summary>
        [AWSProperty(Max=3072)]
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
        /// Gets and sets the property Properties. 
        /// <para>
        /// The new list of properties. Overwrites the current property list.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropertiesToRemove. 
        /// <para>
        /// A list of properties to remove.
        /// </para>
        /// </summary>
        public List<string> PropertiesToRemove
        {
            get { return this._propertiesToRemove; }
            set { this._propertiesToRemove = value; }
        }

        // Check to see if PropertiesToRemove property is set
        internal bool IsSetPropertiesToRemove()
        {
            return this._propertiesToRemove != null && this._propertiesToRemove.Count > 0; 
        }

    }
}