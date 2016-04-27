//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// This exception is thrown when the dataset that is attempted to access does
    /// not exist.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class DatasetNotFoundException : DataStorageException
    {
        /// <summary>
        /// Constructs a new DatasetNotFoundException with the specified message and an existing exception object
        /// </summary>
        public DatasetNotFoundException(string detailMessage, Exception ex)
            : base(detailMessage, ex)
        {
        }
        /// <summary>
        /// Constructs a new DatasetNotFoundException with the specified message
        /// </summary>
        public DatasetNotFoundException(string detailMessage)
            : base(detailMessage)
        {
        }
        /// <summary>
        /// Constructs a new DatasetNotFoundException with  an existing exception object
        /// </summary>
        public DatasetNotFoundException(Exception ex)
            : base(ex.Message, ex)
        {
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the DatasetNotFoundException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected DatasetNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}

