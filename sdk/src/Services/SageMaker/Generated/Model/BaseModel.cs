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
    /// Identifies the foundation model that was used as the starting point for model customization.
    /// </summary>
    public partial class BaseModel
    {
        private string _hubContentName;
        private string _hubContentVersion;
        private string _recipeName;

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        ///  The hub content name of the base model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string HubContentName
        {
            get { return this._hubContentName; }
            set { this._hubContentName = value; }
        }

        // Check to see if HubContentName property is set
        internal bool IsSetHubContentName()
        {
            return this._hubContentName != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentVersion. 
        /// <para>
        ///  The hub content version of the base model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=14)]
        public string HubContentVersion
        {
            get { return this._hubContentVersion; }
            set { this._hubContentVersion = value; }
        }

        // Check to see if HubContentVersion property is set
        internal bool IsSetHubContentVersion()
        {
            return this._hubContentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeName. 
        /// <para>
        ///  The recipe name of the base model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string RecipeName
        {
            get { return this._recipeName; }
            set { this._recipeName = value; }
        }

        // Check to see if RecipeName property is set
        internal bool IsSetRecipeName()
        {
            return this._recipeName != null;
        }

    }
}