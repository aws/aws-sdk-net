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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// A property change that was cancelled for an Amazon OpenSearch Service domain.
    /// </summary>
    public partial class CancelledChangeProperty
    {
        private string _activeValue;
        private string _cancelledValue;
        private string _propertyName;

        /// <summary>
        /// Gets and sets the property ActiveValue. 
        /// <para>
        /// The current value of the property, after the change was cancelled.
        /// </para>
        /// </summary>
        public string ActiveValue
        {
            get { return this._activeValue; }
            set { this._activeValue = value; }
        }

        // Check to see if ActiveValue property is set
        internal bool IsSetActiveValue()
        {
            return this._activeValue != null;
        }

        /// <summary>
        /// Gets and sets the property CancelledValue. 
        /// <para>
        /// The pending value of the property that was cancelled. This would have been the eventual
        /// value of the property if the chance had not been cancelled.
        /// </para>
        /// </summary>
        public string CancelledValue
        {
            get { return this._cancelledValue; }
            set { this._cancelledValue = value; }
        }

        // Check to see if CancelledValue property is set
        internal bool IsSetCancelledValue()
        {
            return this._cancelledValue != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// The name of the property whose change was cancelled.
        /// </para>
        /// </summary>
        public string PropertyName
        {
            get { return this._propertyName; }
            set { this._propertyName = value; }
        }

        // Check to see if PropertyName property is set
        internal bool IsSetPropertyName()
        {
            return this._propertyName != null;
        }

    }
}