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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Custom snapshot and AMI policies only]</b> Specifies a cross-Region copy rule
    /// for a snapshot and AMI policies.
    /// 
    ///  <note> 
    /// <para>
    /// To specify a cross-Region copy action for event-based polices, use <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_CrossRegionCopyAction.html">CrossRegionCopyAction</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CrossRegionCopyRule
    {
        private string _cmkArn;
        private bool? _copyTags;
        private CrossRegionCopyDeprecateRule _deprecateRule;
        private bool? _encrypted;
        private CrossRegionCopyRetainRule _retainRule;
        private string _target;
        private string _targetRegion;

        /// <summary>
        /// Gets and sets the property CmkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to use for EBS encryption. If this parameter
        /// is not specified, the default KMS key for the account is used.
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
        /// Indicates whether to copy all user-defined tags from the source snapshot or AMI to
        /// the cross-Region copy.
        /// </para>
        /// </summary>
        public bool? CopyTags
        {
            get { return this._copyTags; }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeprecateRule. 
        /// <para>
        ///  <b>[Custom AMI policies only]</b> The AMI deprecation rule for cross-Region AMI copies
        /// created by the rule.
        /// </para>
        /// </summary>
        public CrossRegionCopyDeprecateRule DeprecateRule
        {
            get { return this._deprecateRule; }
            set { this._deprecateRule = value; }
        }

        // Check to see if DeprecateRule property is set
        internal bool IsSetDeprecateRule()
        {
            return this._deprecateRule != null;
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
        public bool? Encrypted
        {
            get { return this._encrypted; }
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
        /// The retention rule that indicates how long the cross-Region snapshot or AMI copies
        /// are to be retained in the destination Region.
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
        /// Gets and sets the property Target. <note> 
        /// <para>
        /// Use this parameter for snapshot policies only. For AMI policies, use <b>TargetRegion</b>
        /// instead.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> The target Region or the Amazon Resource Name
        /// (ARN) of the target Outpost for the snapshot copies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property TargetRegion. <note> 
        /// <para>
        /// Use this parameter for AMI policies only. For snapshot policies, use <b>Target</b>
        /// instead. For snapshot policies created before the <b>Target</b> parameter was introduced,
        /// this parameter indicates the target Region for snapshot copies.
        /// </para>
        ///   </note> 
        /// <para>
        ///  <b>[Custom AMI policies only]</b> The target Region or the Amazon Resource Name (ARN)
        /// of the target Outpost for the snapshot copies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
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