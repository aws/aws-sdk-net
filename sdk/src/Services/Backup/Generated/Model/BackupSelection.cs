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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Used to specify a set of resources to a backup plan.
    /// 
    ///  
    /// <para>
    /// Specifying your desired <c>Conditions</c>, <c>ListOfTags</c>, <c>NotResources</c>,
    /// and/or <c>Resources</c> is recommended. If none of these are specified, Backup will
    /// attempt to select all supported and opted-in storage resources, which could have unintended
    /// cost implications.
    /// </para>
    /// </summary>
    public partial class BackupSelection
    {
        private Conditions _conditions;
        private string _iamRoleArn;
        private List<Condition> _listOfTags = AWSConfigs.InitializeCollections ? new List<Condition>() : null;
        private List<string> _notResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _selectionName;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// A list of conditions that you define to assign resources to your backup plans using
        /// tags. For example, <c>"StringEquals": { "Key": "aws:ResourceTag/CreatedByCryo", "Value":
        /// "true" },</c>. Condition operators are case sensitive.
        /// </para>
        ///  
        /// <para>
        ///  <c>Conditions</c> differs from <c>ListOfTags</c> as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you specify more than one condition, you only assign the resources that match
        /// ALL conditions (using AND logic).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Conditions</c> supports <c>StringEquals</c>, <c>StringLike</c>, <c>StringNotEquals</c>,
        /// and <c>StringNotLike</c>. <c>ListOfTags</c> only supports <c>StringEquals</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Conditions Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that Backup uses to authenticate when backing up the target
        /// resource; for example, <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of conditions that you define to assign resources to your backup plans using
        /// tags. For example, <c>"StringEquals": { "Key": "aws:ResourceTag/CreatedByCryo", "Value":
        /// "true" },</c>. Condition operators are case sensitive.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListOfTags</c> differs from <c>Conditions</c> as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you specify more than one condition, you assign all resources that match AT LEAST
        /// ONE condition (using OR logic).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ListOfTags</c> only supports <c>StringEquals</c>. <c>Conditions</c> supports <c>StringEquals</c>,
        /// <c>StringLike</c>, <c>StringNotEquals</c>, and <c>StringNotLike</c>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Condition> ListOfTags
        {
            get { return this._listOfTags; }
            set { this._listOfTags = value; }
        }

        // Check to see if ListOfTags property is set
        internal bool IsSetListOfTags()
        {
            return this._listOfTags != null && (this._listOfTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotResources. 
        /// <para>
        /// A list of Amazon Resource Names (ARNs) to exclude from a backup plan. The maximum
        /// number of ARNs is 500 without wildcards, or 30 ARNs with wildcards.
        /// </para>
        ///  
        /// <para>
        /// If you need to exclude many resources from a backup plan, consider a different resource
        /// selection strategy, such as assigning only one or a few resource types or refining
        /// your resource selection using tags.
        /// </para>
        /// </summary>
        public List<string> NotResources
        {
            get { return this._notResources; }
            set { this._notResources = value; }
        }

        // Check to see if NotResources property is set
        internal bool IsSetNotResources()
        {
            return this._notResources != null && (this._notResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// A list of Amazon Resource Names (ARNs) to assign to a backup plan. The maximum number
        /// of ARNs is 500 without wildcards, or 30 ARNs with wildcards.
        /// </para>
        ///  
        /// <para>
        /// If you need to assign many resources to a backup plan, consider a different resource
        /// selection strategy, such as assigning all resources of a resource type or refining
        /// your resource selection using tags.
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
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelectionName. 
        /// <para>
        /// The display name of a resource selection document. Must contain 1 to 50 alphanumeric
        /// or '-_.' characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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