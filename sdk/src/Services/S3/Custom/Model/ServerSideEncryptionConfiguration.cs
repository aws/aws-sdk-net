﻿/*
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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// ServerSideEncryptionConfiguration class
    /// </summary>
    public class ServerSideEncryptionConfiguration
    {
        private List<ServerSideEncryptionRule> serverSideEncryptionRules = AWSConfigs.InitializeCollections ? new List<ServerSideEncryptionRule>() : null;

        /// <summary>
        /// Container for information about a particular server-side encryption configuration rule.
        /// </summary>
        public List<ServerSideEncryptionRule> ServerSideEncryptionRules
        {
            get { return this.serverSideEncryptionRules; }
            set { this.serverSideEncryptionRules = value; }
        }

        // Check to see if ServerSideEncryptionRules property is set
        internal bool IsSetServerSideEncryptionRules()
        {
            return this.serverSideEncryptionRules != null && (this.serverSideEncryptionRules.Count > 0 || !AWSConfigs.InitializeCollections);
        }
    }
}