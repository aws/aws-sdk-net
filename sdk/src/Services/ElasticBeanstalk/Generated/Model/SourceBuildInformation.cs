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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SourceBuildInformation
    {
        private string _sourceLocation;
        private SourceRepository _sourceRepository;
        private SourceType _sourceType;

        /// <summary>
        /// Gets and sets the property SourceLocation.
        /// </summary>
        public string SourceLocation
        {
            get { return this._sourceLocation; }
            set { this._sourceLocation = value; }
        }

        // Check to see if SourceLocation property is set
        internal bool IsSetSourceLocation()
        {
            return this._sourceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRepository.
        /// </summary>
        public SourceRepository SourceRepository
        {
            get { return this._sourceRepository; }
            set { this._sourceRepository = value; }
        }

        // Check to see if SourceRepository property is set
        internal bool IsSetSourceRepository()
        {
            return this._sourceRepository != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType.
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}