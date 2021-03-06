﻿/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: https://catlib.io/
 */

namespace CatLib
{
    /// <summary>
    /// Indicates that the framework will terminate.
    /// </summary>
    public class BeforeTerminateEventArgs : ApplicationEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeforeTerminateEventArgs"/> class.
        /// </summary>
        /// <param name="application">The terminate application instance.</param>
        public BeforeTerminateEventArgs(IApplication application)
            : base(application)
        {
        }
    }
}
