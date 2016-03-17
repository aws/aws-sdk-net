/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>Rules Item
    /// </summary>
    public class LifecycleRule
    {
        
        private string id;
        private string prefix;
        private LifecycleRuleExpiration expiration;
        private LifecycleRuleStatus status = LifecycleRuleStatus.Disabled;
        private LifecycleTransition transition;
        private LifecycleRuleNoncurrentVersionTransition noncurrentVersionTransition;
        private LifecycleRuleNoncurrentVersionExpiration noncurrentVersionExpiration;
        private List<LifecycleTransition> transitions;
        private List<LifecycleRuleNoncurrentVersionTransition> noncurrentVersionTransitions;
        private LifecycleRuleAbortIncompleteMultipartUpload abortIncompleteMultipartUpload;


        /// <summary>
        /// Defines the length of time, in days, before objects expire.
        /// </summary>
        public LifecycleRuleExpiration Expiration
        {
            get { return this.expiration; }
            set { this.expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this.expiration != null;
        }

        /// <summary>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if ID property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// Prefix identifying one or more objects to which the rule applies.
        ///  
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// If 'Enabled', the rule is currently being applied. If 'Disabled', the rule is not currently being applied.
        ///  
        /// </summary>
        public LifecycleRuleStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The transition rule that describes when objects transition to a different storage class.
        /// <para>
        /// Lifecycle rules can now contain multiple transitions. This property is obsolete in favor of the Transitions property.
        /// This property will aways get or set the the zeroth element in the Transitions collection.
        /// </para>
        /// </summary>
        [Obsolete("The Transition property is now obsolete in favor the Transitions property.")]
        public LifecycleTransition Transition
        {
            get
            {
                if (!this.IsSetTransitions())
                    return null;

                return this.Transitions[0];
            }
            set
            {
                if (this.Transitions.Count == 0)
                    this.Transitions.Add(value);
                else
                    this.Transitions[0] = value;
            }
        }

        // Check to see if Transition property is set
        internal bool IsSetTransition()
        {
            return this.transition != null;
        }

        /// <summary>
        /// Defines the length of time, in days, before noncurrent versions expire.
        /// </summary>
        public LifecycleRuleNoncurrentVersionExpiration NoncurrentVersionExpiration
        {
            get { return this.noncurrentVersionExpiration; }
            set { this.noncurrentVersionExpiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetNoncurrentVersionExpiration()
        {
            return this.noncurrentVersionExpiration != null;
        }

        /// <summary>
        /// The transition rule that describes when noncurrent versions transition to
        /// a different storage class.
        /// <para>
        /// Lifecycle rules can now contain multiple noncurrent version transitions. This property
        /// is obsolete in favor of the NoncurrentVersionTransitions property.
        /// This property will aways get or set the the zeroth element in the NoncurrentVersionTransitions collection.
        /// </para>
        /// </summary>
        [Obsolete("The NoncurrentVersionTransition property is now obsolete in favor the NoncurrentVersionTransitions property.")]
        public LifecycleRuleNoncurrentVersionTransition NoncurrentVersionTransition
        {
            get
            {
                if (!this.IsSetNoncurrentVersionTransitions())
                    return null;

                return this.NoncurrentVersionTransitions[0];
            }
            set
            {
                if (this.NoncurrentVersionTransitions.Count == 0)
                    this.NoncurrentVersionTransitions.Add(value);
                else
                    this.NoncurrentVersionTransitions[0] = value;
            }
        }

        // Check to see if Transition property is set
        internal bool IsSetNoncurrentVersionTransition()
        {
            return this.noncurrentVersionTransition != null;
        }


        /// <summary>
        /// The transition rules that describe when objects transition to a different storage class.
        /// </summary>
        public List<LifecycleTransition> Transitions
        {
            get
            {
                if (this.transitions == null)
                    this.transitions = new List<LifecycleTransition>();

                return this.transitions;
            }
            set { this.transitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetTransitions()
        {
            return this.transitions != null && this.transitions.Count > 0;
        }


        /// <summary>
        /// The transition rules that describe when noncurrent versions transition to
        /// a different storage class.
        /// </summary>
        public List<LifecycleRuleNoncurrentVersionTransition> NoncurrentVersionTransitions
        {
            get
            {
                if (this.noncurrentVersionTransitions == null)
                    this.noncurrentVersionTransitions = new List<LifecycleRuleNoncurrentVersionTransition>();

                return this.noncurrentVersionTransitions;
            }
            set { this.noncurrentVersionTransitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetNoncurrentVersionTransitions()
        {
            return this.noncurrentVersionTransitions != null && this.noncurrentVersionTransitions.Count > 0;
        }


        /// <summary>
        /// Specifies the days since the initiation of an Incomplete Multipart Upload
        /// that Lifecycle will wait before permanently removing all parts of the upload.
        /// </summary>
        public LifecycleRuleAbortIncompleteMultipartUpload AbortIncompleteMultipartUpload
        {
            get { return this.abortIncompleteMultipartUpload; }
            set { this.abortIncompleteMultipartUpload = value; }
        }

        // Check to see if AbortIncompleteMultipartUpload property is set
        internal bool IsSetAbortIncompleteMultipartUpload()
        {
            return this.abortIncompleteMultipartUpload != null;
        }
    }
}
