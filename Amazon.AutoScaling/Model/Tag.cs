/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>Tag
    /// </summary>
    public class Tag  
    {
        
        private string resourceId;
        private string resourceType;
        private string key;
        private string value;
        private bool? propagateAtLaunch;
        public string ResourceId
        {
            get { return this.resourceId; }
            set { this.resourceId = value; }
        }

        /// <summary>
        /// Sets the ResourceId property
        /// </summary>
        /// <param name="resourceId">The value to set for the ResourceId property </param>
        /// <returns>this instance</returns>
        public Tag WithResourceId(string resourceId)
        {
            this.resourceId = resourceId;
            return this;
        }
            

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this.resourceId != null;       
        }
        public string ResourceType
        {
            get { return this.resourceType; }
            set { this.resourceType = value; }
        }

        /// <summary>
        /// Sets the ResourceType property
        /// </summary>
        /// <param name="resourceType">The value to set for the ResourceType property </param>
        /// <returns>this instance</returns>
        public Tag WithResourceType(string resourceType)
        {
            this.resourceType = resourceType;
            return this;
        }
            

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this.resourceType != null;       
        }
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property
        /// </summary>
        /// <param name="key">The value to set for the Key property </param>
        /// <returns>this instance</returns>
        public Tag WithKey(string key)
        {
            this.key = key;
            return this;
        }
            

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;       
        }
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value to set for the Value property </param>
        /// <returns>this instance</returns>
        public Tag WithValue(string value)
        {
            this.value = value;
            return this;
        }
            

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;       
        }
        public bool PropagateAtLaunch
        {
            get { return this.propagateAtLaunch ?? default(bool); }
            set { this.propagateAtLaunch = value; }
        }

        /// <summary>
        /// Sets the PropagateAtLaunch property
        /// </summary>
        /// <param name="propagateAtLaunch">The value to set for the PropagateAtLaunch property </param>
        /// <returns>this instance</returns>
        public Tag WithPropagateAtLaunch(bool propagateAtLaunch)
        {
            this.propagateAtLaunch = propagateAtLaunch;
            return this;
        }
            

        // Check to see if PropagateAtLaunch property is set
        internal bool IsSetPropagateAtLaunch()
        {
            return this.propagateAtLaunch.HasValue;       
        }
    }
}
