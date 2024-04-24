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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Information about a dataset that contains permissions for row-level security (RLS).
    /// The permissions dataset maps fields to users or groups. For more information, see
    /// <a href="https://docs.aws.amazon.com/quicksight/latest/user/restrict-access-to-a-data-set-using-row-level-security.html">Using
    /// Row-Level Security (RLS) to Restrict Access to a Dataset</a> in the <i>Amazon QuickSight
    /// User Guide</i>.
    /// 
    ///  
    /// <para>
    /// The option to deny permissions by setting <c>PermissionPolicy</c> to <c>DENY_ACCESS</c>
    /// is not supported for new RLS datasets.
    /// </para>
    /// </summary>
    public partial class RowLevelPermissionDataSet
    {
        private string _arn;
        private RowLevelPermissionFormatVersion _formatVersion;
        private string _awsNamespace;
        private RowLevelPermissionPolicy _permissionPolicy;
        private Status _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset that contains permissions for RLS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The user or group rules associated with the dataset that contains permissions for
        /// RLS.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>FormatVersion</c> is <c>VERSION_1</c>. When <c>FormatVersion</c> is
        /// <c>VERSION_1</c>, <c>UserName</c> and <c>GroupName</c> are required. When <c>FormatVersion</c>
        /// is <c>VERSION_2</c>, <c>UserARN</c> and <c>GroupARN</c> are required, and <c>Namespace</c>
        /// must not exist.
        /// </para>
        /// </summary>
        public RowLevelPermissionFormatVersion FormatVersion
        {
            get { return this._formatVersion; }
            set { this._formatVersion = value; }
        }

        // Check to see if FormatVersion property is set
        internal bool IsSetFormatVersion()
        {
            return this._formatVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace associated with the dataset that contains permissions for RLS.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionPolicy. 
        /// <para>
        /// The type of permissions to use when interpreting the permissions for RLS. <c>DENY_ACCESS</c>
        /// is included for backward compatibility only.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RowLevelPermissionPolicy PermissionPolicy
        {
            get { return this._permissionPolicy; }
            set { this._permissionPolicy = value; }
        }

        // Check to see if PermissionPolicy property is set
        internal bool IsSetPermissionPolicy()
        {
            return this._permissionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the row-level security permission dataset. If enabled, the status is
        /// <c>ENABLED</c>. If disabled, the status is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}