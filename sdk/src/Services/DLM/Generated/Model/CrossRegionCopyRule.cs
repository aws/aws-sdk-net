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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies a rule for cross-Region snapshot copies.
    /// </summary>
    public partial class CrossRegionCopyRule
    {
        private string _cmkArn;
        private bool? _copyTags;
        private bool? _encrypted;
        private CrossRegionCopyRetainRule _retainRule;
        private string _targetRegion;

        /// <summary>
        /// Gets and sets the property CmkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS KMS customer master key (CMK) to use for
        /// EBS encryption. If this parameter is not specified, your AWS managed CMK for EBS is
        /// used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string CmkArn
        {
            get { return this._cmkArn; }
            set { this._cmkArn = value; }
        }

        // Check to see if CmkArn property is set
        internal bool IsSetCmkArn()
        {
            return this._cmkArn != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Copy all user-defined tags from the source snapshot to the copied snapshot.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// To encrypt a copy of an unencrypted snapshot if encryption by default is not enabled,
        /// enable encryption using this parameter. Copies of encrypted snapshots are encrypted,
        /// even if this parameter is false or if encryption by default is not enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetainRule. 
        /// <para>
        /// The retention rule.
        /// </para>
        /// </summary>
        public CrossRegionCopyRetainRule RetainRule
        {
            get { return this._retainRule; }
            set { this._retainRule = value; }
        }

        // Check to see if RetainRule property is set
        internal bool IsSetRetainRule()
        {
            return this._retainRule != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The target Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=16)]
        public string TargetRegion
        {
            get { return this._targetRegion; }
            set { this._targetRegion = value; }
        }

        // Check to see if TargetRegion property is set
        internal bool IsSetTargetRegion()
        {
            return this._targetRegion != null;
        }

    }
}