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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A single selector statement in an advanced event selector.
    /// </summary>
    public partial class AdvancedFieldSelector
    {
        private List<string> _endsWith = new List<string>();
        private List<string> _equals = new List<string>();
        private string _field;
        private List<string> _notEndsWith = new List<string>();
        private List<string> _notEquals = new List<string>();
        private List<string> _notStartsWith = new List<string>();
        private List<string> _startsWith = new List<string>();

        /// <summary>
        /// Gets and sets the property EndsWith. 
        /// <para>
        ///  An operator that includes events that match the last few characters of the event
        /// record field specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> EndsWith
        {
            get { return this._endsWith; }
            set { this._endsWith = value; }
        }

        // Check to see if EndsWith property is set
        internal bool IsSetEndsWith()
        {
            return this._endsWith != null && this._endsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        ///  An operator that includes events that match the exact value of the event record field
        /// specified as the value of <code>Field</code>. This is the only valid operator that
        /// you can use with the <code>readOnly</code>, <code>eventCategory</code>, and <code>resources.type</code>
        /// fields. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null && this._equals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        ///  A field in an event record on which to filter events to be logged. Supported fields
        /// include <code>readOnly</code>, <code>eventCategory</code>, <code>eventSource</code>
        /// (for management events), <code>eventName</code>, <code>resources.type</code>, and
        /// <code>resources.ARN</code>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>readOnly</code> </b> - Optional. Can be set to <code>Equals</code> a value
        /// of <code>true</code> or <code>false</code>. A value of <code>false</code> logs both
        /// <code>read</code> and <code>write</code> events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>eventSource</code> </b> - For filtering management events only. This can
        /// be set only to <code>NotEquals</code> <code>kms.amazonaws.com</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>eventName</code> </b> - Can use any operator. You can use it to ﬁlter in
        /// or ﬁlter out any data event logged to CloudTrail, such as <code>PutBucket</code>.
        /// You can have multiple values for this ﬁeld, separated by commas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>eventCategory</code> </b> - This is required. It must be set to <code>Equals</code>,
        /// and the value must be <code>Management</code> or <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>resources.type</code> </b> - This ﬁeld is required. <code>resources.type</code>
        /// can only use the <code>Equals</code> operator, and the value can be one of the following:
        /// <code>AWS::S3::Object</code> or <code>AWS::Lambda::Function</code>. You can have only
        /// one <code>resources.type</code> ﬁeld per selector. To log data events on more than
        /// one resource type, add another selector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>resources.ARN</code> </b> - You can use any operator with resources.ARN,
        /// but if you use <code>Equals</code> or <code>NotEquals</code>, the value must exactly
        /// match the ARN of a valid resource of the type you've speciﬁed in the template as the
        /// value of resources.type. For example, if resources.type equals <code>AWS::S3::Object</code>,
        /// the ARN must be in one of the following formats. The trailing slash is intentional;
        /// do not exclude it.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:partition:s3:::bucket_name/</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:partition:s3:::bucket_name/object_or_file_name/</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When resources.type equals <code>AWS::Lambda::Function</code>, and the operator is
        /// set to <code>Equals</code> or <code>NotEquals</code>, the ARN must be in the following
        /// format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:partition:lambda:region:account_ID:function:function_name</code> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property NotEndsWith. 
        /// <para>
        ///  An operator that excludes events that match the last few characters of the event
        /// record field specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEndsWith
        {
            get { return this._notEndsWith; }
            set { this._notEndsWith = value; }
        }

        // Check to see if NotEndsWith property is set
        internal bool IsSetNotEndsWith()
        {
            return this._notEndsWith != null && this._notEndsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        ///  An operator that excludes events that match the exact value of the event record field
        /// specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEquals
        {
            get { return this._notEquals; }
            set { this._notEquals = value; }
        }

        // Check to see if NotEquals property is set
        internal bool IsSetNotEquals()
        {
            return this._notEquals != null && this._notEquals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotStartsWith. 
        /// <para>
        ///  An operator that excludes events that match the first few characters of the event
        /// record field specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotStartsWith
        {
            get { return this._notStartsWith; }
            set { this._notStartsWith = value; }
        }

        // Check to see if NotStartsWith property is set
        internal bool IsSetNotStartsWith()
        {
            return this._notStartsWith != null && this._notStartsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartsWith. 
        /// <para>
        ///  An operator that includes events that match the first few characters of the event
        /// record field specified as the value of <code>Field</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> StartsWith
        {
            get { return this._startsWith; }
            set { this._startsWith = value; }
        }

        // Check to see if StartsWith property is set
        internal bool IsSetStartsWith()
        {
            return this._startsWith != null && this._startsWith.Count > 0; 
        }

    }
}