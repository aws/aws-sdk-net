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
        public LifecycleTransition Transition
        {
            get { return this.transition; }
            set { this.transition = value; }
        }

        // Check to see if Transition property is set
        internal bool IsSetTransition()
        {
            return this.transition != null;
        }
    }
}
