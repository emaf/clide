﻿#region BSD License
/* 
Copyright (c) 2012, Clarius Consulting
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

* Neither the name of Clarius Consulting nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

namespace Clide.Commands
{
    using System;

    /// <summary>
    /// Manages commands in the environment.
    /// </summary>
    public interface ICommandManager
    {
        /// <summary>
        /// Adds the command of the given type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the command, which
        /// must implement the <see cref="ICommandExtension"/> interface and be annotated with 
        /// the <see cref="CommandAttribute"/> attribute.</typeparam>
        /// <remarks>
        /// The command can import additional services, which are satisfied right after creation.
        /// </remarks>
        void AddCommand<T>() where T : ICommandExtension, new();

        /// <summary>
        /// Adds the specified command implementation to the manager.
        /// </summary>
        /// <param name="command">The command instance, which must be annotated with 
        /// the <see cref="CommandAttribute"/> attribute.</param>
        /// <remarks>
        /// The manager performs a satisfy imports call for pre-instantiated commands 
        /// so that property dependencies are set.
        /// </remarks>
        void AddCommand(ICommandExtension command);

        /// <summary>
        /// Adds the specified command implementation to the manager, 
        /// with the specified explicit metadata.
        /// </summary>
        /// <param name="command">The command instance, which does not need to 
        /// be annotated with the <see cref="CommandAttribute"/> attribute since 
        /// it's provided explicitly.</param>
        /// <param name="metadata">Explicit metadata to use for the command, 
        /// instead of reflecting the <see cref="CommandAttribute"/>.</param>
        /// <remarks>
        /// The manager performs a satisfy imports call for pre-instantiated commands 
        /// so that property dependencies are set.
        /// </remarks>
        void AddCommand(ICommandExtension command, ICommandMetadata metadata);

        /// <summary>
        /// Adds all the commands that have been annotated with the <see cref="CommandAttribute"/> with 
        /// a package identifier that matches the <see cref="GuidAttribute"/> 
        /// on the given <paramref name="owningPackage"/>.
        /// </summary>
        void AddCommands(IServiceProvider owningPackage);

        /// <summary>
        /// Adds the command filter of the given type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the command filter, which
        /// must implement the <see cref="ICommandFilter"/> interface and be annotated with 
        /// the <see cref="CommandFilterAttribute"/> attribute.</typeparam>
        /// <remarks>
        /// The command can import additional services, which are satisfied right after creation.
        /// </remarks>
        void AddFilter<T>() where T : ICommandFilter, new();

        /// <summary>
        /// Adds the specified command filter implementation to the manager.
        /// </summary>
        /// <param name="filter">The command filter instance, which must be annotated with 
        /// the <see cref="CommandFilterAttribute"/> attribute.</param>
        /// <remarks>
        /// The manager performs a satisfy imports call for pre-instantiated commands 
        /// so that property dependencies are set.
        /// </remarks>
        void AddFilter(ICommandFilter filter);

        /// <summary>
        /// Adds the specified command filter implementation to the manager, 
        /// with the specified explicit metadata.
        /// </summary>
        /// <param name="command">The command filter instance, which does not need to 
        /// be annotated with the <see cref="CommandFilterAttribute"/> attribute since 
        /// it's provided explicitly.</param>
        /// <param name="metadata">Explicit metadata to use for the command, 
        /// instead of reflecting the <see cref="CommandFilterAttribute"/>.</param>
        /// <remarks>
        /// The manager performs a satisfy imports call for pre-instantiated commands 
        /// so that property dependencies are set.
        /// </remarks>
        void AddFilter(ICommandFilter filter, ICommandFilterMetadata metadata);

        /// <summary>
        /// Adds all the commands filters that have been annotated with the <see cref="CommandFilterAttribute"/> with 
        /// a package identifier that matches the <see cref="GuidAttribute"/> 
        /// on the given <paramref name="owningPackage"/>.
        /// </summary>
        void AddFilters(IServiceProvider owningPackage);
    }
}
