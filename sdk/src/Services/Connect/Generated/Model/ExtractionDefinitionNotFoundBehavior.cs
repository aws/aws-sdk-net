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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The behavior configuration when an extraction definition cannot find the target value.
    /// </summary>
    public partial class ExtractionDefinitionNotFoundBehavior
    {
        private NotFoundBehaviorType _behavior;
        private string _defaultValue;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The behavior type. <c>USE_DEFAULT_VALUE</c> returns the specified default value. <c>OMIT</c>
        /// excludes the field from the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotFoundBehaviorType Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to use when the behavior is <c>USE_DEFAULT_VALUE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

    }
}