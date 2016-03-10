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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIdFormat operation.
    /// Modifies the ID format for the specified resource on a per-region basis. You can specify
    /// that resources should receive longer IDs (17-character IDs) when they are created.
    /// The following resource types support longer IDs: <code>instance</code> | <code>reservation</code>.
    /// 
    ///  
    /// <para>
    /// This setting applies to the IAM user who makes the request; it does not apply to the
    /// entire AWS account. By default, an IAM user defaults to the same settings as the root
    /// user. If you're using this action as the root user or as an IAM role that has permission
    /// to use this action, then these settings apply to the entire account, unless an IAM
    /// user explicitly overrides these settings for themselves. For more information, see
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html#resource-ids-access">Controlling
    /// Access to Longer ID Settings</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Resources created with longer IDs are visible to all IAM users, regardless of these
    /// settings and provided that they have permission to use the relevant <code>Describe</code>
    /// command for the resource type.
    /// </para>
    /// </summary>
    public partial class ModifyIdFormatRequest : AmazonEC2Request
    {
        private string _resource;
        private bool? _useLongIds;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property UseLongIds. 
        /// <para>
        /// Indicate whether the resource should use longer IDs (17-character IDs).
        /// </para>
        /// </summary>
        public bool UseLongIds
        {
            get { return this._useLongIds.GetValueOrDefault(); }
            set { this._useLongIds = value; }
        }

        // Check to see if UseLongIds property is set
        internal bool IsSetUseLongIds()
        {
            return this._useLongIds.HasValue; 
        }

    }
}