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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// An error or warning for a desired configuration option value.
    /// </summary>
    public partial class ValidationMessage
    {
        private string _message;
        private string _namespace;
        private string _optionName;
        private ValidationSeverity _severity;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ValidationMessage() { }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  A message describing the error or warning. 
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._namespace != null;
        }

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string OptionName
        {
            get { return this._optionName; }
            set { this._optionName = value; }
        }

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this._optionName != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        ///  An indication of the severity of this message: 
        /// </para>
        ///  <enumValues> <value name="error"> 
        /// <para>
        ///  error: This message indicates that this is not a valid setting for an option. 
        /// </para>
        ///  </value> <value name="warning"> 
        /// <para>
        ///  warning: This message is providing information you should take into account. 
        /// </para>
        ///  </value> </enumValues> <ul> <li> error: This message indicates that this is not a
        /// valid setting for an option. </li> <li> warning: This message is providing information
        /// you should take into account. </li> </ul>
        /// </summary>
        public ValidationSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

    }
}