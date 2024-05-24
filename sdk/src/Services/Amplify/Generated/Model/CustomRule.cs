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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes a custom rewrite or redirect rule.
    /// </summary>
    public partial class CustomRule
    {
        private string _condition;
        private string _source;
        private string _status;
        private string _target;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition for a URL rewrite or redirect rule, such as a country code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source pattern for a URL rewrite or redirect rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status code for a URL rewrite or redirect rule. 
        /// </para>
        ///  <dl> <dt>200</dt> <dd> 
        /// <para>
        /// Represents a 200 rewrite rule.
        /// </para>
        ///  </dd> <dt>301</dt> <dd> 
        /// <para>
        /// Represents a 301 (moved permanently) redirect rule. This and all future requests should
        /// be directed to the target URL. 
        /// </para>
        ///  </dd> <dt>302</dt> <dd> 
        /// <para>
        /// Represents a 302 temporary redirect rule.
        /// </para>
        ///  </dd> <dt>404</dt> <dd> 
        /// <para>
        /// Represents a 404 redirect rule.
        /// </para>
        ///  </dd> <dt>404-200</dt> <dd> 
        /// <para>
        /// Represents a 404 rewrite rule.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Min=3, Max=7)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target pattern for a URL rewrite or redirect rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}