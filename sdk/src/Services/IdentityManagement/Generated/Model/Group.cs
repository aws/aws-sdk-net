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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an IAM group entity.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the following operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGroups</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Group
    {
        private string _arn;
        private DateTime? _createDate;
        private string _groupId;
        private string _groupName;
        private string _path;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Group() { }

        /// <summary>
        /// Instantiates Group with the parameterized properties
        /// </summary>
        /// <param name="path">The path to the group. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide. </param>
        /// <param name="groupName">The friendly name that identifies the group.</param>
        /// <param name="groupId"> The stable and unique string identifying the group. For more information about IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide. </param>
        /// <param name="arn"> The Amazon Resource Name (ARN) specifying the group. For more information about ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide. </param>
        /// <param name="createDate">The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time format</a>, when the group was created.</param>
        public Group(string path, string groupName, string groupId, string arn, DateTime createDate)
        {
            _path = path;
            _groupName = groupName;
            _groupId = groupId;
            _arn = arn;
            _createDate = createDate;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) specifying the group. For more information about ARNs
        /// and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the group was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        ///  The stable and unique string identifying the group. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The friendly name that identifies the group.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the group. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}