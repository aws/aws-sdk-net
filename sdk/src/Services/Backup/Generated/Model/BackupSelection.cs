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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Used to specify a set of resources to a backup plan.
    /// </summary>
    public partial class BackupSelection
    {
        private string _iamRoleArn;
        private List<Condition> _listOfTags = new List<Condition>();
        private List<string> _resources = new List<string>();
        private string _selectionName;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that AWS Backup uses to authenticate when restoring the target
        /// resource; for example, <code>arn:aws:iam::123456789012:role/S3Access</code>.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ListOfTags. 
        /// <para>
        /// An array of conditions used to specify a set of resources to assign to a backup plan;
        /// for example, <code>"StringEquals": {"ec2:ResourceTag/Department": "accounting"</code>.
        /// </para>
        /// </summary>
        public List<Condition> ListOfTags
        {
            get { return this._listOfTags; }
            set { this._listOfTags = value; }
        }

        // Check to see if ListOfTags property is set
        internal bool IsSetListOfTags()
        {
            return this._listOfTags != null && this._listOfTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// An array of strings that either contain Amazon Resource Names (ARNs) or match patterns
        /// such as "<code>arn:aws:ec2:us-east-1:123456789012:volume/*</code>" of resources to
        /// assign to a backup plan.
        /// </para>
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SelectionName. 
        /// <para>
        /// The display name of a resource selection document.
        /// </para>
        /// </summary>
        public string SelectionName
        {
            get { return this._selectionName; }
            set { this._selectionName = value; }
        }

        // Check to see if SelectionName property is set
        internal bool IsSetSelectionName()
        {
            return this._selectionName != null;
        }

    }
}