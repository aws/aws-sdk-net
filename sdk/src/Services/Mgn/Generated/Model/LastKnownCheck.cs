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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Last known check performed on a launched instance.
    /// </summary>
    public partial class LastKnownCheck
    {
        private DateTime? _checkedAt;
        private string _error;
        private string _name;
        private LastKnownCheckStatus _status;
        private LastKnownCheckType _type;

        /// <summary>
        /// Gets and sets the property CheckedAt. 
        /// <para>
        /// Last known check timestamp.
        /// </para>
        /// </summary>
        public DateTime? CheckedAt
        {
            get { return this._checkedAt; }
            set { this._checkedAt = value; }
        }

        // Check to see if CheckedAt property is set
        internal bool IsSetCheckedAt()
        {
            return this._checkedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Last known check error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Last known check name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Last known check status.
        /// </para>
        /// </summary>
        public LastKnownCheckStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Last known check type.
        /// </para>
        /// </summary>
        public LastKnownCheckType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}