﻿/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Text;

namespace Amazon.Runtime
{
    /// <summary>
    /// Abstract class for Response objects, contains only metadata, 
    /// and no result information.
    /// </summary>
    public class AmazonWebServiceResponse
    {
        private ResponseMetadata responseMetaDataField;

        /// <summary>
        /// Contains additional information about the request, such as the 
        /// Request Id.
        /// </summary>
        public ResponseMetadata ResponseMetadata
        {
            get { return  responseMetaDataField; }
            set { responseMetaDataField = value; }
        }
    }
}
