/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Values defining a lifecycle rule.
    /// </summary>
    public class LifecycleRule
    {
        private string id;
        private string prefix;
        private LifecycleRuleExpiration expiration;
        private LifecycleRuleStatus status;
        private LifecycleTransition transition;

        /// <summary>
        /// Unique identifier for the rule.
        /// </summary>
        [XmlElement(ElementName="ID")]
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// The prefix property for the rule. Identifies one or more objects in a bucket to which
        /// the rule applies.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        /// <summary>
        /// Defines the length of time, in days, before objects expire.
        /// </summary>
        public LifecycleRuleExpiration Expiration
        {
            get { return this.expiration; }
            set { this.expiration = value; }
        }

        /// <summary>
        /// If Enabled, the rule is currently being applied. If Disabled, the rule is not currently being applied.
        /// </summary>
        public LifecycleRuleStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Gets and sets the transition property of the rule
        /// </summary>
        public LifecycleTransition Transition
        {
            get { return this.transition; }
            set { this.transition = value; }
    }
    }

    /// <summary>
    /// An enumeration of all supported lifecycle rule statuses
    /// </summary>
    public enum LifecycleRuleStatus { Enabled, Disabled }
}
