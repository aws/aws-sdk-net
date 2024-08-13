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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Creates a new recommended Application Component (AppComponent).
    /// </summary>
    public partial class GroupingAppComponent
    {
        private string _appComponentId;
        private string _appComponentName;
        private string _appComponentType;

        /// <summary>
        /// Gets and sets the property AppComponentId. 
        /// <para>
        /// Indicates the identifier of an AppComponent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppComponentId
        {
            get { return this._appComponentId; }
            set { this._appComponentId = value; }
        }

        // Check to see if AppComponentId property is set
        internal bool IsSetAppComponentId()
        {
            return this._appComponentId != null;
        }

        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// Indicates the name of an AppComponent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppComponentName
        {
            get { return this._appComponentName; }
            set { this._appComponentName = value; }
        }

        // Check to see if AppComponentName property is set
        internal bool IsSetAppComponentName()
        {
            return this._appComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property AppComponentType. 
        /// <para>
        /// Indicates the type of an AppComponent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AppComponentType
        {
            get { return this._appComponentType; }
            set { this._appComponentType = value; }
        }

        // Check to see if AppComponentType property is set
        internal bool IsSetAppComponentType()
        {
            return this._appComponentType != null;
        }

    }
}