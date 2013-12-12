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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents an operation to perform - either <i>DeleteItem</i> or <i>PutItem</i> . You can only specify one of these operations, not
    /// both, in a single <i>WriteRequest</i> . If you do need to perform both of these operations, you will need to specify two separate
    /// <i>WriteRequest</i> objects.</para>
    /// </summary>
    public class WriteRequest
    {
        
        private PutRequest putRequest;
        private DeleteRequest deleteRequest;


        /// <summary>
        /// Represents a request to perform a <i>PutItem</i> operation.
        ///  
        /// </summary>
        public PutRequest PutRequest
        {
            get { return this.putRequest; }
            set { this.putRequest = value; }
        }

        // Check to see if PutRequest property is set
        internal bool IsSetPutRequest()
        {
            return this.putRequest != null;
        }

        /// <summary>
        /// Represents a request to perform a <i>DeleteItem</i> operation.
        ///  
        /// </summary>
        public DeleteRequest DeleteRequest
        {
            get { return this.deleteRequest; }
            set { this.deleteRequest = value; }
        }

        // Check to see if DeleteRequest property is set
        internal bool IsSetDeleteRequest()
        {
            return this.deleteRequest != null;
        }
    }
}
