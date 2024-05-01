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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// Returns information about the configuration element or attribute that was sanitized
    /// in the configuration.
    /// </summary>
    public partial class SanitizationWarning
    {
        private string _attributeName;
        private string _elementName;
        private SanitizationWarningReason _reason;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the configuration attribute that has been sanitized.
        /// </para>
        /// </summary>
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property ElementName. 
        /// <para>
        /// The name of the configuration element that has been sanitized.
        /// </para>
        /// </summary>
        public string ElementName
        {
            get { return this._elementName; }
            set { this._elementName = value; }
        }

        // Check to see if ElementName property is set
        internal bool IsSetElementName()
        {
            return this._elementName != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for which the configuration elements or attributes were sanitized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SanitizationWarningReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}