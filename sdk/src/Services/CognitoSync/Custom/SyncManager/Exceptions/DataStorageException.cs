//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//

using System;
using Amazon.Runtime;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// This exception is thrown when an error occurs during an data storage
    /// operation.
    /// </summary>
#if !PCL
    [Serializable]
#endif
    public class DataStorageException : SyncManagerException
    {
        /// <summary>
        /// Constructs a new DataStorageException with the specified message and an existing exception object
        /// </summary>
        public DataStorageException(string detailMessage, Exception ex)
            : base(detailMessage, ex)
        {
        }
        /// <summary>
        /// Constructs a new DataStorageException with the specified message 
        /// </summary>
        public DataStorageException(string detailMessage)
            : base(detailMessage)
        {
        }
        /// <summary>
        /// Constructs a new DataStorageException with an existing exception object
        /// </summary>
        public DataStorageException(Exception ex)
            : base(ex.Message, ex)
        {
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the DataStorageException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected DataStorageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}

